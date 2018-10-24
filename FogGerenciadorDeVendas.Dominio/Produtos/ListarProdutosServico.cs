using FogGerenciadorDeVendas.Dominio.Produtos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dominio.Produtos
{
    public class ListarProdutosServico
    {
        private readonly IProdutosRepositorio _produtosRepositorio;
        public ListarProdutosServico(IProdutosRepositorio produtosRepositorio)
        {
            _produtosRepositorio = produtosRepositorio;
        }

        public List<ListarProdutoDto> PesquisarPorCodigoOuNome(string codigoOuNome)
        {
            return  _produtosRepositorio.PesquisarPorCodigoOuNome(codigoOuNome)
                .Select(c => new ListarProdutoDto
                {
                    Codigo = c.Id,
                    Nome = c.Nome,
                    Descricao = c.Descricao,
                    Valor = c.Valor,
                    DataDeCadastro = c.DataDeCadastro.ToString("dd/MM/yyyy")
                }).ToList();
        }
    }
}
