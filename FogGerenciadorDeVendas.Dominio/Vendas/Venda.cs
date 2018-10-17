using FogGerenciadorDeVendas.Dominio.Consumos;
using System;

namespace FogGerenciadorDeVendas.Dominio.Vendas
{
    public class Venda
    {
        public int Id { get; set; }
        public int ConsumoId { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal PorcentagemDeDesconto{ get; set; }
        public decimal ValorComDesconto { get; set; }
        public DateTime DataDaVenda { get; set; }
        public virtual Consumo Consumo { get; set; }
    }
}
