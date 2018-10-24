using FogGerenciadorDeVendas.Dominio.Consumos;
using System;
using System.Collections.Generic;

namespace FogGerenciadorDeVendas.Dominio.Vendas
{
    public class Venda
    {
        public Venda() { }
        public Venda(int consumoId, decimal valorTotal, int porcentagemDeDesconto, List<VendaProdutos> vendaProdutos)
        {
            ConsumoId = consumoId;
            ValorTotal = valorTotal;
            PorcentagemDeDesconto = porcentagemDeDesconto;
            VendasProdutos = vendaProdutos;
        }

        public int Id { get; set; }
        public int ConsumoId { get; set; }
        public decimal ValorTotal { get; set; }
        public int PorcentagemDeDesconto{ get; set; }
        public DateTime DataDaVenda { get; set; }
        public virtual Consumo Consumo { get; set; }
        public virtual List<VendaProdutos> VendasProdutos { get; set; } = new List<VendaProdutos>();
    }
}
