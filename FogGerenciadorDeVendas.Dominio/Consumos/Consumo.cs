using FogGerenciadorDeVendas.Dominio.Consumos.Enums;
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
        protected Consumo() { }
        public Consumo(string codigoComanda)
        {
            CodigoDaComanda = codigoComanda;
            DataDeAbertura = DateTime.Now;
            Situacao = (int)SituacaoConsumoEnum.Aberto;
        }

        public int Id { get; private set; }
        public string CodigoDaComanda { get; private set; }
        public int Quantidade { get; private set; }
        public int Situacao { get; private set; }
        public DateTime DataDeAbertura { get; private set; }
        public DateTime? DataDeFechamento { get; private set; }
        public virtual List<Lancamento> Lancamentos { get; set; } = new List<Lancamento>();

        public void AlterarDataDeFechamento(DateTime dataDeFechamento)
        {
            DataDeFechamento = dataDeFechamento;
        }

        public void AlterarSituacao(SituacaoConsumoEnum situacao)
        {
            Situacao = (int) situacao;
        }

        public void AlterarQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        } 
    }
}
