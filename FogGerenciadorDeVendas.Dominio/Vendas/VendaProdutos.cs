namespace FogGerenciadorDeVendas.Dominio.Vendas
{
    public class VendaProdutos
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public int VendaId { get; set; }
        public virtual Venda Venda{ get; set; }
    }
}