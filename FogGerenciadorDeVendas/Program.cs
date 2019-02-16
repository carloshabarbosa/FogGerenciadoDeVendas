using FogGerenciadorDeVendas.CrossCutting;
using FogGerenciadorDeVendas.Telas.Controles.Produtos;
using System;
using System.Windows.Forms;
using Unity;

namespace FogGerenciadorDeVendas
{
    public static class Program
    {
        public static IUnityContainer container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var teste = new AutorizacaoHomolog.nfeAutorizacaoLoteRequest();
            //var teste = new ConsultaChaveAcessoHomolog.
            //var teste = new ConsultaReciboHomolog.
            //var teste = new ConsultaStatusServiceHomolog.
            //var teste = InutilizacaoHomolog.
            container = BuildContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Home>());


        }

        public static IUnityContainer BuildContainer()
        {
            var currentContainer = new UnityContainer();
            DependencyRegister.Register(currentContainer);
            currentContainer.RegisterType<Produtos>();
            return currentContainer;
        }
    }
}
