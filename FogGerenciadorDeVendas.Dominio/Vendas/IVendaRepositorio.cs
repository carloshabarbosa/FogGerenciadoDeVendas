using System;
using System.Collections.Generic;
using FogGerenciadorDeVendas.Dominio.Repositorio;

namespace FogGerenciadorDeVendas.Dominio.Vendas
{
    public interface IVendaRepositorio : IRepositorio<int, Venda>
    {
        List<Venda> ObterRelatorioDeVenda(DateTime dataInicio, DateTime dataFim);
    }
}