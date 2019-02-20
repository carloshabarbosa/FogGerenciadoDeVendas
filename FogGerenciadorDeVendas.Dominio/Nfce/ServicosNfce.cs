using System;
using System.Collections.Generic;
using System.Net;
using DFe.Classes.Flags;
using DFe.Utils;
using FogGerenciadorDeVendas.Dominio.Produtos;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Utils;

namespace FogGerenciadorDeVendas.Dominio.Nfce
{
    public class ServicosNfce
    {
        private readonly Configuracao _configuracoes;
        private ConfiguracaoServico _cfgServico;
        private readonly GeradorDeNfce _geradorDeNfce;

        public ConfiguracaoServico CfgServico
        {
            get
            {
                ConfiguracaoServico.Instancia.CopiarPropriedades(_cfgServico);
                return _cfgServico;
            }
            set
            {
                _cfgServico = value;
                ConfiguracaoServico.Instancia.CopiarPropriedades(value);
            }
        }

        public ServicosNfce()
        {
            CfgServico = ConfiguracaoServico.Instancia;
            CfgServico.tpAmb = TipoAmbiente.Homologacao;
            CfgServico.tpEmis = TipoEmissao.teNormal;
            CfgServico.ProtocoloDeSeguranca = ServicePointManager.SecurityProtocol;

            _geradorDeNfce = new GeradorDeNfce(CfgServico);

        }
        public void EnviarNfce(List<Produto> produtos)
        {
            var ultimoNumeroDaNota = 2;
            var nfe = _geradorDeNfce.GerarNfce(ultimoNumeroDaNota, produtos);
            var servicoNFe = new ServicosNFe(CfgServico);

            var lote = 2;

            var retorno = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { nfe }, true);

            var teste = 1;
        }
    }
}