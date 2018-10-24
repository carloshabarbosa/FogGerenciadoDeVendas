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

namespace FogGerenciadorDeVendas.Telas.Controles.Vendas
{
    public partial class Venda : MetroUserControl
    {
        private readonly InstanciarConsumoService _instanciarConsumoService;
        public Venda(InstanciarConsumoService instanciarConsumoService)
        {
            _instanciarConsumoService = instanciarConsumoService;
            InitializeComponent();
        }

        private void txt_comanda_Leave(object sender, System.EventArgs e)
        {
            var consumo = _instanciarConsumoService.RecuperarConsumo(txt_comanda.Text);

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
                GridProdutosHelper.MontarGridProdutosReduzida(resultado_produtos_grid, consumo.Lancamentos
                    .Select(c => new ListarProdutoDto
                    {
                        Codigo = c.Produto.Id,
                        Descricao = c.Produto.Descricao,
                        Nome = c.Produto.Nome,
                        DataDeCadastro = c.Produto.DataDeCadastro.ToString("dd/MM/yyyy"),
                        Valor = c.Produto.Valor
                    }).ToList());
            }
        }

        private void resultado_produtos_grid_DataSourceChanged(object sender, System.EventArgs e)
        {
            SomarValorTotal();
        }

        private void SomarValorTotal()
        {
            var valorTotal = SomarValoresDaLista();
            valorTotal = SomarValorDaEntrada(valorTotal);

            valorTotal = CalcularDesconto(valorTotal);

            lb_valor_total.Text = $"{valorTotal:C}";
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

        private decimal SomarValorDaEntrada(decimal valor)
        {
            if (!string.IsNullOrEmpty(txt_valor_entrada.Text))
            {
                if (decimal.TryParse(txt_valor_entrada.Text.Replace("R$ ", "").Replace(",", "."), out var valorASomar))
                {
                    valor += valorASomar;
                }

                return valor;
            }

            return valor;
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
            SomarValorTotal();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txt_valor_entrada.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txt_valor_entrada.TextChanged -= metroTextBox1_TextChanged;
                //Format the text as currency
                txt_valor_entrada.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                txt_valor_entrada.TextChanged += metroTextBox1_TextChanged;
                txt_valor_entrada.Select(txt_valor_entrada.Text.Length, 0);
            }
            else
            {
                txt_valor_entrada.Text = "R$ 0,00";
            }
            bool goodToGo = TextisValid(txt_valor_entrada.Text);

            if (!goodToGo)
            {
                txt_valor_entrada.Text = txt_valor_entrada.Text.Substring(0, txt_valor_entrada.Text.Length - 1);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^R\$\D(\d{1,3}(\,\d{1,3})*|(d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }
    }
}
