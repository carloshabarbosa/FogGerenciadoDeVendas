using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using DFe.Utils.Assinatura;
using FogGerenciadorDeVendas.Dominio.Produtos;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.Autorizacao;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Utils;
using NFe.Utils.Autorizacao;
using Shared.DFe.Utils;

namespace FogGerenciadorDeVendas.Dominio.Nfce
{
    public class ServicosNfce
    {
        private readonly Configuracao _configuracoes;
        private ConfiguracaoServico _cfgServico;
        private readonly GeradorDeNfce _geradorDeNfce;
        private readonly X509Certificate2 _cert;
        private const string CaminhoEnvioNota = "C:/fog_notas/Envio";
        private const string CaminhoBackup = "C:/fog_notas/nfce/backup";
        private const string CaminhoRetorno = "C:/fog_notas/Retorno";
        private const string SufixoProcesso = "-proc-rec";
        private const string SufixoLote = "-num-lote";


        public ServicosNfce()
        {
            string schemas = System.Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\Schemas");
            _cfgServico = new ConfiguracaoServico
            {
                tpAmb = TipoAmbiente.Homologacao,
                tpEmis = TipoEmissao.teNormal,
                ProtocoloDeSeguranca = ServicePointManager.SecurityProtocol,
                DefineVersaoServicosAutomaticamente = true,
                DiretorioSchemas = schemas,
                VersaoNFeDistribuicaoDFe = VersaoServico.ve400,
                ModeloDocumento = ModeloDocumento.NFCe,
                VersaoLayout = VersaoServico.ve400, 
                VersaoNFeAutorizacao = VersaoServico.ve400,
                VersaoNFeRetAutorizacao = VersaoServico.ve400,
                VersaoNfceAministracaoCSC = VersaoServico.ve400,
                VersaoNfeConsultaCadastro = VersaoServico.ve400,
                VersaoNfeConsultaDest = VersaoServico.ve400,
                VersaoNfeConsultaProtocolo = VersaoServico.ve400,
                VersaoNfeDownloadNF = VersaoServico.ve400,
                VersaoNfeInutilizacao = VersaoServico.ve400,
                VersaoNfeRecepcao = VersaoServico.ve400,
                VersaoNfeRetRecepcao = VersaoServico.ve400,
                VersaoNfeStatusServico = VersaoServico.ve400,
                VersaoRecepcaoEventoCceCancelamento = VersaoServico.ve400,
                VersaoRecepcaoEventoEpec = VersaoServico.ve400,
                VersaoRecepcaoEventoManifestacaoDestinatario = VersaoServico.ve400,
                cUF = Estado.PR
            };
            var cert = CertificadoDigital.RecuperarCertificado();
            _cert = cert;


            _geradorDeNfce = new GeradorDeNfce(_cfgServico, _cert);

        }
        public void EnviarNfce(List<Produto> produtos)
        {
            var ultimoNumeroDaNota = 2;
            var nfe = _geradorDeNfce.GerarNfce(ultimoNumeroDaNota, produtos);

            var lote = 2;

            var pedEnvio =
                new enviNFe4(ServicoNFe.NFeAutorizacao.VersaoServicoParaString(_cfgServico.VersaoNFeAutorizacao), lote,
                    IndicadorSincronizacao.Sincrono, new List<NFe.Classes.NFe> {nfe});

            var xmlEnvio = _cfgServico.RemoverAcentos
                ? pedEnvio.ObterXmlString().RemoverAcentos()
                : pedEnvio.ObterXmlString();

            var dadosEnvio = new XmlDocument();
            xmlEnvio = xmlEnvio.Replace("<NFe>", "<NFe xmlns=\"http://www.portalfiscal.inf.br/nfe\">");
            dadosEnvio.LoadXml(xmlEnvio);

            dadosEnvio.Save($"{CaminhoBackup}/{nfe.infNFe.Id.Substring(3)}-nfe.xml");
            dadosEnvio.Save($"{CaminhoEnvioNota}/{nfe.infNFe.Id.Substring(3)}-nfe.xml");
        }
    }
}