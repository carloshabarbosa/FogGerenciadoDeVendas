using System;
using System.Collections.Generic;
using System.Net;
using DFe.Classes.Flags;
using DFe.Utils;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.Tipos;
using NFe.Danfe.Base;
using NFe.Danfe.Base.NFCe;
using NFe.Servicos;
using NFe.Utils;
using NFe.Utils.Email;

namespace FogGerenciadorDeVendas.Dominio.Nfce.Nfce
{
    public class ServicosNfce
    {
        private readonly Configuracao _configuracoes;
        private ConfiguracaoServico _cfgServico;

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

        }
        public void EnviarNfce(NFe.Classes.NFe nfe)
        {
            var servicoNFe = new ServicosNFe(CfgServico);

            var lote = 1;

            servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { nfe }, true);
        }
    }
}