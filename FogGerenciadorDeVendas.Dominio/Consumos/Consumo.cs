using FogGerenciadorDeVendas.Dominio.Lancamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dominio.Consumos
{
    public class Consumo
    {
        public int Id { get; set; }
        public string CodigoDaComanda { get; set; }
        public int Quantidade { get; set; }
        public int Situacao { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public DateTime? DataDeFechamento { get; set; }
        public virtual IList<Lancamento> Lancamentos { get; set; } = new List<Lancamento>();
    }
}
