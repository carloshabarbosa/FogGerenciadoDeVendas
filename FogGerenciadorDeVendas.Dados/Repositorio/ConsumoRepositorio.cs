using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Dominio.Consumos.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dados.Repositorio
{
    public class ConsumoRepositorio : RepositorioBase<int, Consumo>, IConsumoRepositorio
    {
        public ConsumoRepositorio(FogContext context) : base(context)
        {
        }

        public Consumo RecuperarConsumoAtivoPeloCodigoDaComanda(string codigoComanda)
        {
            return Buscar().Include(c => c.Lancamentos).ThenInclude(c => c.Produto).FirstOrDefault(c =>
                c.Situacao == (int) SituacaoConsumoEnum.Aberto &&
                c.CodigoDaComanda.ToLower() == codigoComanda.ToLower());
        }
    }
}
