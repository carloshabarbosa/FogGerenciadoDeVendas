using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dominio.Consumos
{
    public class InstanciarConsumoService
    {
        private readonly IConsumoRepositorio _consumoRepositorio;

        public InstanciarConsumoService(IConsumoRepositorio consumoRepositorio)
        {
            _consumoRepositorio = consumoRepositorio;
        }

        public Consumo RecuperarConsumo(string codigoDaComanda)
        {
            Consumo consumo;
            consumo = _consumoRepositorio.RecuperarConsumoAtivoPeloCodigoDaComanda(codigoDaComanda);

            if (consumo == null)
            {
                consumo = new Consumo(codigoDaComanda);
                _consumoRepositorio.Adicionar(consumo);
            }

            return consumo;
        }
    }
}
