using MetroFramework.Controls;
using FogGerenciadorDeVendas.Dominio.Produtos;
using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Telas.Controles.Produtos.Helper;
using FogGerenciadorDeVendas.Dominio.Consumos.Enums;
using System.Drawing;
using System.Collections.Generic;
using FogGerenciadorDeVendas.Dominio.Produtos.Dto;
using System.Linq;
using MetroFramework;
using System.Windows.Forms;
using System;

namespace FogGerenciadorDeVendas.Telas.Controles.Consumos
{
    public partial class Cadastrar : MetroUserControl
    {
        private readonly ListarProdutosServico _listarProdutoService;
        private readonly InstanciarConsumoService _instanciarConsumoService;
        private readonly IConsumoRepositorio _consumoRepositorio;
        private readonly IProdutosRepositorio _produtoRepositorio;

        public Cadastrar(ListarProdutosServico listarProdutoService,
            InstanciarConsumoService instanciarConsumoService,
            IConsumoRepositorio consumoRepositorio,
            IProdutosRepositorio produtoRepositorio)
        {
            _listarProdutoService = listarProdutoService;
            _instanciarConsumoService = instanciarConsumoService;
            _consumoRepositorio = consumoRepositorio;
            _produtoRepositorio = produtoRepositorio;
            InitializeComponent();
            MontarGridProdutos();
        }

        public void MontarGridProdutos(string codigoOuNome = "")
        {
            GridProdutosHelper.MontarGridProdutosNomeEDescricao(selecionar_produtos_grid, _listarProdutoService.PesquisarPorCodigoOuNome(codigoOuNome));
        }

        private void metroTextBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            var codigoOuNome = txt_codigo_nome.Text;
            if (codigoOuNome.Length % 3 == 0 || codigoOuNome.Length == 1)
            {
                MontarGridProdutos(codigoOuNome);
            }
        }

        private void txt_comanda_Leave(object sender, System.EventArgs e)
        {
            var consumo = _consumoRepositorio.RecuperarConsumoAtivoPeloCodigoDaComanda(txt_comanda.Text);

            GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, new List<ListarProdutoDto>());

            if (consumo == null)
            {
                lb_codigo_comanda.Text = txt_comanda.Text;
                lb_status_comanda.Text = SituacaoConsumoEnum.Fechado.ToString();
                lb_status_comanda.ForeColor = Color.Red;
            }
            else
            {
                lb_codigo_comanda.Text = consumo.CodigoDaComanda;
                lb_status_comanda.Text = ((SituacaoConsumoEnum)consumo.Situacao).ToString();
                lb_status_comanda.ForeColor = Color.Green;
                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, consumo.Lancamentos.Select(c => new ListarProdutoDto
                {
                    Codigo = c.Produto.Id,
                    Descricao = c.Produto.Descricao,
                    Nome = c.Produto.Nome,
                    DataDeCadastro = c.Produto.DataDeCadastro.ToString("dd/MM/yyyy"),
                    Valor = c.Produto.Valor
                }).ToList());
            }
        }

        private void btn_adicionar_produto_comanda_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_comanda.Text))
            {
                MetroMessageBox.Show(this, "Entre com o código da comanda primeiro!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var consumo = _instanciarConsumoService.RecuperarConsumo(txt_comanda.Text);
                lb_status_comanda.Text = ((SituacaoConsumoEnum) consumo.Situacao).ToString();
                lb_status_comanda.ForeColor = consumo.Situacao == SituacaoConsumoEnum.Aberto.GetHashCode() ? 
                    Color.Green :
                    Color.Red;
                if (selecionar_produtos_grid.SelectedRows.Count == 1)
                {
                    var produto = _produtoRepositorio
                        .ObtemPorId((int)selecionar_produtos_grid.SelectedRows[0].Cells[0].Value);

                    if (int.TryParse(txt_qtd.Text, out var qtd))
                    {
                        for (int i = 0; i < qtd; i++)
                        {
                            consumo.Lancamentos.Add(new Dominio.Lancamentos.Lancamento
                            {
                                ProdutoId = produto.Id,
                                CodigoDaComanda = consumo.CodigoDaComanda,
                                DataDeLancamento = DateTime.Now
                            });
                        }
                    }
                    else
                    {
                        consumo.Lancamentos.Add(new Dominio.Lancamentos.Lancamento
                        {
                            ProdutoId = produto.Id,
                            CodigoDaComanda = consumo.CodigoDaComanda,
                            DataDeLancamento = DateTime.Now
                        });
                    }

                    _consumoRepositorio.Salvar();
                }

                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid,
                    consumo.Lancamentos.Select(l => new ListarProdutoDto
                    {
                        Codigo = l.Produto.Id,
                        DataDeCadastro = l.Produto.DataDeCadastro.ToString("dd/MM/yyy"),
                        Descricao = l.Produto.Descricao,
                        Nome = l.Produto.Nome,
                        Valor = l.Produto.Valor
                    }).ToList());
            }

        }

        private void txt_qtd_TextChanged(object sender, System.EventArgs e)
        {
            if (!int.TryParse(txt_qtd.Text, out var qtd))
            {
                txt_qtd.Text = "0";
            }
        }

        private void btn_delete_produto_selecionar_Click(object sender, System.EventArgs e)
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

        private void resultado_produtos_grid_DataSourceChanged(object sender, System.EventArgs e)
        {
            if (resultado_produtos_grid.DataSource != null)
            {
                var lista = (List<ListarProdutoDto>)resultado_produtos_grid.DataSource;

                var valorTotal = lista.Sum(c => c.Valor);

                lb_valor_total.Text = string.Format("{0:C}", valorTotal);

            }
        }

        private void btn_adicionar_consumo_Click(object sender, System.EventArgs e)
        {
            if (resultado_produtos_grid.DataSource != null)
            {
                try
                {
                    Consumo consumo;

                    consumo = _consumoRepositorio.RecuperarConsumoAtivoPeloCodigoDaComanda(txt_comanda.Text);

                    var listaLancamentos = (List<ListarProdutoDto>)resultado_produtos_grid.DataSource;

                    if (consumo == null)
                    {
                        consumo = new Consumo(txt_comanda.Text);
                        _consumoRepositorio.Adicionar(consumo);
                    };

                    consumo.Lancamentos = listaLancamentos.Select(c => new Dominio.Lancamentos.Lancamento
                    {
                        CodigoDaComanda = txt_comanda.Text,
                        ConsumoId = consumo.Id,
                        ProdutoId = c.Codigo,
                        DataDeLancamento = DateTime.Now
                    }).ToList();

                    _consumoRepositorio.Salvar();

                    MessageBox.Show(this, "\n\nConsumo lançado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void selecionar_produtos_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resultado_produtos_grid_SelectionChanged(object sender, EventArgs e)
        {
            btn_delete_produto_selecionar.Enabled = false;
            if (resultado_produtos_grid.SelectedRows.Count == 1)
            {
                btn_delete_produto_selecionar.Enabled = true;
            }
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
