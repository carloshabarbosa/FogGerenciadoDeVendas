using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FogGerenciadorDeVendas.Dominio.Vendas;
using FogGerenciadorDeVendas.Dominio.Vendas.Dtos;
using MetroFramework;
using MetroFramework.Controls;
using Microsoft.EntityFrameworkCore.Internal;
using OfficeOpenXml;
using OfficeOpenXml.Utils;

namespace FogGerenciadorDeVendas.Telas.Controles.Relatorios
{
    public partial class RelatorioDeVenda : MetroUserControl
    {
        private readonly IVendaRepositorio _vendaRepositorio;
        public RelatorioDeVenda(IVendaRepositorio vendaRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
            InitializeComponent();
        }

        private void btn_fechar_venda_Click(object sender, System.EventArgs e)
        {
            
            var dataInicioEscolhida = data_de.Text;
            var horaInicioEscolhida = hora_de.Text;
            var minutoInicioEscolha = minuto_de.Text;

            var dataFimEscolhida = data_ate.Text;
            var horaFimEscolhida = hora_ate.Text;
            var minutoFimEscolha = minuto_ate.Text;

            if (DateTime.TryParse($"{dataInicioEscolhida} {horaInicioEscolhida}:{minutoInicioEscolha}", out var dataInicio) &&
                DateTime.TryParse($"{dataFimEscolhida} {horaFimEscolhida}:{minutoFimEscolha}", out var dataFim))
            {
                var vendasPorPeriodo = _vendaRepositorio.ObterRelatorioDeVenda(dataInicio, dataFim);

                if (vendasPorPeriodo != null && vendasPorPeriodo.Any())
                {
                    var salvarArquivo = new SaveFileDialog();
                    salvarArquivo.Filter = "Arquivo de excel | .xlsx";
                    if (salvarArquivo.ShowDialog() == DialogResult.OK)
                    {
                        var vendasPorPeriodoDto = vendasPorPeriodo.Select(v => new RelatorioDeVendaDto
                        {
                            CodigoDaVenda = v.Id,
                            CodigoDaComanda = v.Consumo.CodigoDaComanda,
                            QuantidadeDeItens = v.Consumo.Quantidade,
                            ValorTotal = v.ValorTotal,
                            PorcentagemDeDesconto = v.PorcentagemDeDesconto,
                            ValorComDesconto = v.ValorComDesconto,
                            DataDeAberturaDoConsumo = v.Consumo.DataDeAbertura.ToString("dd/MM/yyyy HH:mm"),
                            DataDeFechamentoDoConsumo = v.Consumo.DataDeFechamento.HasValue ?
                                v.Consumo.DataDeFechamento.Value.ToString("dd/MM/yyyy HH:mm") :
                                ""
                        });

                        var newFile = new FileInfo(salvarArquivo.FileName);

                        using (ExcelPackage package = new ExcelPackage(newFile))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("RelatorioDeVendas");
                            worksheet.Cells["A1"].Value = "Código da venda";
                            worksheet.Cells["B1"].Value = "Código da comanda";
                            worksheet.Cells["C1"].Value = "Quantidade de produtos";
                            worksheet.Cells["D1"].Value = "Valor total";
                            worksheet.Cells["E1"].Value = "Porcentagem de desconto";
                            worksheet.Cells["F1"].Value = "Valor com desconto";
                            worksheet.Cells["G1"].Value = "Data de abertura da comanda";
                            worksheet.Cells["H1"].Value = "Data de fechamento da comanda";


                            worksheet.Cells["A2"].LoadFromCollection(vendasPorPeriodoDto, false, OfficeOpenXml.Table.TableStyles.Medium1);

                            package.Save();
                        }

                        MetroMessageBox.Show(this, "Relatório gerado com sucesso", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Não existe vendas para o período informado", "Ops",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = IsDigitOrBackspace(e);
        }

        private bool IsDigitOrBackspace(System.Windows.Forms.KeyPressEventArgs e)
        {
            return (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));
        }

        private void minuto_de_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsDigitOrBackspace(e);
        }

        private void hora_ate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsDigitOrBackspace(e);
        }

        private void minuto_ate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsDigitOrBackspace(e);
        }
    }
}
