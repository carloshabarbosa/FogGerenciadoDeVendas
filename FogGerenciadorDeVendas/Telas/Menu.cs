using FogGerenciadorDeVendas.Telas.Controles.Produtos;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Linq;
using FogGerenciadorDeVendas.Telas.Controles.Vendas;
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
            produtos.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(produtos);
        }

        private void btn_novo_consumo_Click(object sender, EventArgs e)
        {
            var novoConsumo = Program.container.Resolve<Telas.Controles.Consumos.Cadastrar>();
            novoConsumo.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(novoConsumo);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var venda = Program.container.Resolve<Venda>();
            venda.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(venda);
        }
    }
}
