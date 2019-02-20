using FogGerenciadorDeVendas.Dominio.Repositorio;
using System.Collections.Generic;

namespace FogGerenciadorDeVendas.Dominio.Produtos
{
    public interface IProdutosRepositorio : IRepositorio<int, Produto>
    {
        List<Produto> PesquisarPorCodigoOuNome(string codigoOuNome);
        List<Produto> PesquisarPorIds(List<int> ids);
    }
}
