﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FogGerenciadorDeVendas.InutilizacaoHomolog {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NFeInutilizacao4", ConfigurationName="InutilizacaoHomolog.NFeInutilizacao4Soap12")]
    public interface NFeInutilizacao4Soap12 {
        
        // CODEGEN: Generating message contract since the operation nfeInutilizacaoNF is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NFeInutilizacao4/nfeInutilizacaoNF", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse nfeInutilizacaoNF(FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NFeInutilizacao4/nfeInutilizacaoNF", ReplyAction="*")]
        System.Threading.Tasks.Task<FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse> nfeInutilizacaoNFAsync(FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeInutilizacaoNFRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NFeInutilizacao4", Order=0)]
        public System.Xml.XmlNode nfeDadosMsg;
        
        public nfeInutilizacaoNFRequest() {
        }
        
        public nfeInutilizacaoNFRequest(System.Xml.XmlNode nfeDadosMsg) {
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeInutilizacaoNFResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NFeInutilizacao4", Order=0)]
        public System.Xml.XmlNode nfeResultMsg;
        
        public nfeInutilizacaoNFResponse() {
        }
        
        public nfeInutilizacaoNFResponse(System.Xml.XmlNode nfeResultMsg) {
            this.nfeResultMsg = nfeResultMsg;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NFeInutilizacao4Soap12Channel : FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NFeInutilizacao4Soap12Client : System.ServiceModel.ClientBase<FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12>, FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12 {
        
        public NFeInutilizacao4Soap12Client() {
        }
        
        public NFeInutilizacao4Soap12Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NFeInutilizacao4Soap12Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NFeInutilizacao4Soap12Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NFeInutilizacao4Soap12Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12.nfeInutilizacaoNF(FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest request) {
            return base.Channel.nfeInutilizacaoNF(request);
        }
        
        public System.Xml.XmlNode nfeInutilizacaoNF(System.Xml.XmlNode nfeDadosMsg) {
            FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest inValue = new FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest();
            inValue.nfeDadosMsg = nfeDadosMsg;
            FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse retVal = ((FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12)(this)).nfeInutilizacaoNF(inValue);
            return retVal.nfeResultMsg;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse> FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12.nfeInutilizacaoNFAsync(FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest request) {
            return base.Channel.nfeInutilizacaoNFAsync(request);
        }
        
        public System.Threading.Tasks.Task<FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFResponse> nfeInutilizacaoNFAsync(System.Xml.XmlNode nfeDadosMsg) {
            FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest inValue = new FogGerenciadorDeVendas.InutilizacaoHomolog.nfeInutilizacaoNFRequest();
            inValue.nfeDadosMsg = nfeDadosMsg;
            return ((FogGerenciadorDeVendas.InutilizacaoHomolog.NFeInutilizacao4Soap12)(this)).nfeInutilizacaoNFAsync(inValue);
        }
    }
}
