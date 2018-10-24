namespace FogGerenciadorDeVendas.Dominio.Produtos.Dto
{
    public class ListarProdutoDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ValorFormatado => string.Format("{0:C}", Valor);
        public decimal Valor{ get; set; }
        public string DataDeCadastro { get; set; }
    }
}
