using System;
using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Dominio.Consumos.Enums;
using FogGerenciadorDeVendas.Dominio.Produtos.Dto;
using FogGerenciadorDeVendas.Telas.Controles.Produtos.Helper;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FogGerenciadorDeVendas.Dominio.Vendas;
using MetroFramework;

namespace FogGerenciadorDeVendas.Telas.Controles.Vendas
{
    public partial class Venda : MetroUserControl
    {
        private readonly InstanciarConsumoService _instanciarConsumoService;
        private readonly IConsumoRepositorio _consumoRepositorio;
        private readonly IVendaRepositorio _vendaRepositorio;

        public Venda(InstanciarConsumoService instanciarConsumoService, IConsumoRepositorio consumoRepositorio,
            IVendaRepositorio vendaRepositorio)
        {
            _instanciarConsumoService = instanciarConsumoService;
            _consumoRepositorio = consumoRepositorio;
            _vendaRepositorio = vendaRepositorio;
            InitializeComponent();
        }

        private void txt_comanda_Leave(object sender, System.EventArgs e)
        {
            var consumo = _consumoRepositorio.RecuperarConsumoAtivoPeloCodigoDaComanda(txt_comanda.Text);
            if (consumo == null)
            {
                lb_codigo_comanda.Text = txt_comanda.Text;
                lb_status_comanda.Text = SituacaoConsumoEnum.Fechado.ToString();
                lb_status_comanda.ForeColor = Color.Red;
            }
            else
            {

                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, new List<ListarProdutoDto>());

                lb_codigo_comanda.Text = consumo.CodigoDaComanda;
                lb_status_comanda.Text = ((SituacaoConsumoEnum) consumo.Situacao).ToString();
                lb_status_comanda.ForeColor = Color.Green;
                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, consumo.Lancamentos
                    .Select(c => new ListarProdutoDto
                    {
                        Codigo = c.Produto.Id,
                        Descricao = c.Produto.Descricao,
                        Nome = c.Produto.Nome,
                        DataDeCadastro = c.Produto.DataDeCadastro.ToString("dd/MM/yyyy"),
                        Valor = c.Produto.Valor
                    }).ToList());

                btn_fechar_venda.Enabled = true;
            }
        }

        private void resultado_produtos_grid_DataSourceChanged(object sender, System.EventArgs e)
        {
            lb_valor_total.Text = $"{SomarValorTotal():C}";
        }

        private decimal SomarValorTotal()
        {
            var valorTotal = SomarValoresDaLista();
            valorTotal = CalcularDesconto(valorTotal);

            return valorTotal;

        }

        private decimal SomarValoresDaLista()
        {
            if (resultado_produtos_grid.DataSource != null)
            {
                var lista = (List<ListarProdutoDto>)resultado_produtos_grid.DataSource;

                if (lista.Any())
                {
                    return lista.Sum(c => c.Valor);
                }

                return 0;
            }

            return 0;
        }


        private decimal CalcularDesconto(decimal valorTotal)
        {
            if (double.TryParse(valorTotal.ToString(), out var valor))
            {
                if (!string.IsNullOrEmpty(txt_porc_desconto.Text))
                {
                    var porcentagemDeDesconto = Convert.ToDouble(txt_porc_desconto.Text);
                    var valorDoDesconto = valor * (porcentagemDeDesconto / 100);

                    return Convert.ToDecimal(valor - valorDoDesconto);
                }
            }
            return valorTotal;
        }

        private void txt_porc_desconto_Leave(object sender, System.EventArgs e)
        {
            lb_valor_total.Text = $"{SomarValorTotal():C}";
        }

       
        private void btn_delete_produto_selecionar_Click(object sender, EventArgs e)
        {

            if (resultado_produtos_grid.DataSource != null)
            {
                var lista = (List<ListarProdutoDto>)resultado_produtos_grid.DataSource;
                if (resultado_produtos_grid.SelectedRows.Count == 1)
                {
                    var id = (int)resultado_produtos_grid.SelectedRows[0].Cells[0].Value;

                    var produto = lista.FirstOrDefault(c => c.Codigo == id);

                    lista.Remove(produto);
                }

                var consumo = _instanciarConsumoService.RecuperarConsumo(txt_comanda.Text);
                if (consumo != null)
                {
                    consumo.Lancamentos = lista.Select(c => new Dominio.Lancamentos.Lancamento
                    {
                        CodigoDaComanda = txt_comanda.Text,
                        ConsumoId = consumo.Id,
                        ProdutoId = c.Codigo,
                        DataDeLancamento = DateTime.Now
                    }).ToList();

                    _consumoRepositorio.Salvar();
                }

                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, lista);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarFechamentoVenda())
                {
                    var consumo = _instanciarConsumoService.RecuperarConsumo(txt_comanda.Text);

                    var listaProdutos = (List<ListarProdutoDto>)resultado_produtos_grid.DataSource;

                    var valorTotal = SomarValorTotal();

                    var venda = new Dominio.Vendas.Venda(consumo.Id, valorTotal, int.Parse(txt_porc_desconto.Text),
                        listaProdutos.Select(l => new VendaProdutos
                        {
                            DescricaoProduto = l.Descricao,
                            NomeProduto = l.Nome,
                            ValorProduto = l.Valor
                        }).ToList());

                    _vendaRepositorio.Adicionar(venda);

                    consumo.AlterarDataDeFechamento(DateTime.Now);
                    consumo.AlterarSituacao(SituacaoConsumoEnum.Fechado);

                    _consumoRepositorio.Salvar();

                    MetroMessageBox.Show(this, "Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimparCampos();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void LimparCampos()
        {
            txt_comanda.Text = "";
            GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, new List<ListarProdutoDto>());
            lb_codigo_comanda.Text = "";
            lb_status_comanda.Text = "";
        }

        private bool ValidarFechamentoVenda()
        {
            if (string.IsNullOrEmpty(txt_comanda.Text))
            {
                MetroMessageBox.Show(this, "O campo código da comanda deve ser preenchido", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (resultado_produtos_grid.DataSource == null || !((List<ListarProdutoDto>)resultado_produtos_grid.DataSource).Any())
            {
                MetroMessageBox.Show(this, "Deve ter pelo menos um produto adicionado na comanda", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_porc_desconto.Text, out var desc))
            {
                MetroMessageBox.Show(this, "A porcentagem de desconto deve ser um número", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
