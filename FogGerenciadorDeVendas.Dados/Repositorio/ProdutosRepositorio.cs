using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dominio.Produtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FogGerenciadorDeVendas.Dados.Repositorio
{
    public class ProdutosRepositorio : RepositorioBase<int, Produto>, IProdutosRepositorio
    {
        public ProdutosRepositorio(FogContext context) : base(context)
        {
        }

        public List<Produto> PesquisarPorCodigoOuNome(string codigoOuNome)
        {
            return Buscar()
                .Where(p => string.IsNullOrEmpty(codigoOuNome) ||
                    p.Id.ToString().Contains(codigoOuNome.ToLower()) ||
                    p.Nome.ToLower().Contains(codigoOuNome.ToLower()))
                .ToList();
        }

        public List<Produto> PesquisarPorIds(List<int> ids)
        {
            return Buscar()
                .Where(p => ids.Contains(p.Id))
                .ToList();
        }
    }
}
