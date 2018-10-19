namespace FogGerenciadorDeVendas.Dominio.Produtos.Dto
{
    public class ListarProdutoDto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public string DataDeCadastro { get; set; }
    }
}
