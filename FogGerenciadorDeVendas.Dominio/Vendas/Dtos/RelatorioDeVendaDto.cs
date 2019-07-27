using System;

namespace FogGerenciadorDeVendas.Dominio.Vendas.Dtos
{
    public class RelatorioDeVendaDto
    {
        public int CodigoDaVenda { get; set; }
        public string CodigoDaComanda { get; set; }
        public int QuantidadeDeItens { get; set; }
        public decimal ValorTotal { get; set; }
        public int PorcentagemDeDesconto { get; set; }
        public decimal ValorComDesconto { get; set; }
        public string DataDeAberturaDoConsumo { get; set; }
        public string DataDeFechamentoDoConsumo { get; set; }
    }
}
