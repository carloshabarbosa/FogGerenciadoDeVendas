using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Dominio.Produtos;
using System;

namespace FogGerenciadorDeVendas.Dominio.Lancamentos
{
    public class Lancamento
    {
        public int Id { get; set; }
        public string CodigoDaComanda { get; set; }
        public int ConsumoId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataDeLancamento { get; set; }
        public virtual Consumo Consumo { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
