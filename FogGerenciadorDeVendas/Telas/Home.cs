using FogGerenciadorDeVendas.Extensoes;
using MetroFramework.Forms;
using System.Windows.Forms;
using Unity;

namespace FogGerenciadorDeVendas
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
            this.SetBevel(false);
            var menu = Program.container.Resolve<Menu>();
            menu.MdiParent = this;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.Dock = DockStyle.Fill;
            menu.Show();
        }
    }
}
