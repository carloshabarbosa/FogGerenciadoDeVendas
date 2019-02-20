    using NFe.Classes.Informacoes.Emitente;
using NFe.Danfe.Base.NFCe;
using NFe.Utils;
using NFe.Utils.Email;

namespace FogGerenciadorDeVendas.Dominio.Nfce
{
    public class Configuracao
    {
        public Configuracao(enderEmit enderecoEmitente, ConfiguracaoServico configuracaoServico, emit emitente, 
            ConfiguracaoEmail configuracaoEmail, ConfiguracaoDanfeNfce configuracaoDanfeNfce)
        {
            EnderecoEmitente = enderecoEmitente;
            CfgServico = configuracaoServico;
            Emitente = emitente;
            ConfiguracaoEmail = configuracaoEmail;
            ConfiguracaoDanfeNfce = configuracaoDanfeNfce;
        }

        public enderEmit EnderecoEmitente { get; set; }
        public ConfiguracaoServico CfgServico { get; set; }
        public emit Emitente { get; set; }
        public ConfiguracaoEmail ConfiguracaoEmail { get; set; }
        public ConfiguracaoDanfeNfce ConfiguracaoDanfeNfce { get; set; }
    }
}