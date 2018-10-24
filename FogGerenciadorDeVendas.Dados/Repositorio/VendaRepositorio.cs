using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dominio.Vendas;

namespace FogGerenciadorDeVendas.Dados.Repositorio
{
    public class VendaRepositorio : RepositorioBase<int, Venda>, IVendaRepositorio
    {
        public VendaRepositorio(FogContext context) : base(context)
        {
        }
    }
}