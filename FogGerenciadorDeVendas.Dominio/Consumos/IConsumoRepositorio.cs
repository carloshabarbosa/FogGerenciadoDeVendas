using FogGerenciadorDeVendas.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dominio.Consumos
{
    public interface IConsumoRepositorio : IRepositorio<int, Consumo>
    {
        Consumo RecuperarConsumoAtivoPeloCodigoDaComanda(string codigoComanda);
    }
}
