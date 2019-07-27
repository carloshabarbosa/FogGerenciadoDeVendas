using System;
using System.Collections.Generic;
using System.Linq;
using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dominio.Vendas;
using Microsoft.EntityFrameworkCore;

namespace FogGerenciadorDeVendas.Dados.Repositorio
{
    public class VendaRepositorio : RepositorioBase<int, Venda>, IVendaRepositorio
    {
        private readonly FogContext _context;
        public VendaRepositorio(FogContext context) : base(context)
        {
            _context = context;
        }

        public List<Venda> ObterRelatorioDeVenda(DateTime dataInicio, DateTime dataFim)
        {
            return _context.Set<Venda>()
                .Include(v => v.Consumo)
                .Where(v => v.DataDaVenda >= dataInicio && v.DataDaVenda <= dataFim)
                .ToList();
        }
    }
}