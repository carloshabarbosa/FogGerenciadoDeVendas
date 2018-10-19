using FogGerenciadorDeVendas.Telas.Controles;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Linq;
using Unity;

namespace FogGerenciadorDeVendas
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var produtos = Program.container.Resolve<Produtos>();
            produtos.Size = metroPanel1.Size;
            metroPanel1.Controls.Add(produtos);
        }
    }
}
