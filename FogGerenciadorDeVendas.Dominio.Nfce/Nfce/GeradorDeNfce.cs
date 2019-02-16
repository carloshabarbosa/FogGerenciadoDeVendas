using System;
using DFe.Classes.Entidades;
using DFe.Classes.Extensoes;
using DFe.Classes.Flags;
using NFe.Classes.Informacoes;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.Tipos;
using NFe.Utils;


namespace FogGerenciadorDeVendas.Dominio.Nfce.Nfce
{
    public class GeradorDeXml
    {
        private const VersaoServico versaoDoServico = VersaoServico.ve400;
        private const ModeloDocumento modeloDoDocumento = ModeloDocumento.NFCe;
        private const string IdToken = "000001";
        private const string Csc = "VFF5PWWRGXNE0CJWU99935GFHJHGXUJ3C4OJ";

        public void GerarNfce(int numeroDaNota)
        {
            if (numeroDaNota == 0) throw new Exception("O número da nota é obrigatório");

        }

        private NFe.Classes.NFe ObterNfeValidade(int numero)
        {

        }

        private NFe.Classes.NFe ObterNf(int numero)
        {
            return new NFe.Classes.NFe
            {
                infNFe = 
            };
        }

        private infNFe ObterInf(int numero)
        {
            var infNFe = new infNFe
            {
                versao = versaoDoServico.VersaoServicoParaString(),
                ide = GetIdentificacao(numero, modelo, versao),
                emit = GetEmitente(),
                dest = GetDestinatario(versao, modelo),
                transp = GetTransporte()
            };
        }

        private ide GetIdentificacao(int numero)
        {
            var estado = Estado.SE;

            var ide = new ide
            {
                cUF = estado.SiglaParaEstado(_configuracoes.EnderecoEmitente.UF),
                natOp = "VENDA",
                mod = modeloDoDocumento,
                serie = 1,
                nNF = numero,
                tpNF = TipoNFe.tnSaida,
                cMunFG = _configuracoes.EnderecoEmitente.cMun,
                tpEmis = _configuracoes.CfgServico.tpEmis,
                tpImp = TipoImpressao.tiRetrato,
                cNF = "1234",
                tpAmb = _configuracoes.CfgServico.tpAmb,
                finNFe = FinalidadeNFe.fnNormal,
                verProc = "3.000"
            };

            if (ide.tpEmis != TipoEmissao.teNormal)
            {
                ide.dhCont = DateTime.Now;
                ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
            }

            #region V2.00

            if (versaoDoServico == VersaoServico.ve200)
            {
                ide.dEmi = DateTime.Today; //Mude aqui para enviar a nfe vinculada ao EPEC, V2.00
                ide.dSaiEnt = DateTime.Today;
            }

            #endregion

            #region V3.00

            if (versaoDoServico == VersaoServico.ve200) return ide;

            if (versaoDoServico == VersaoServico.ve310)
            {
                ide.indPag = IndicadorPagamento.ipVista;
            }


            ide.idDest = DestinoOperacao.doInterna;
            ide.dhEmi = DateTime.Now;
            //Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
            if (ide.mod == ModeloDocumento.NFe)
                ide.dhSaiEnt = DateTime.Now;
            else
                ide.tpImp = TipoImpressao.tiNFCe;
            ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
            ide.indFinal = ConsumidorFinal.cfConsumidorFinal; //NFCe: Tem que ser consumidor Final
            ide.indPres = PresencaComprador.pcPresencial; //NFCe: deve ser 1 ou 4

            #endregion

            return ide;
        }
    }
}