using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FogGerenciadorDeVendas.Telas.Helper
{
    public class AlterarTelaHelper
    {
        public static void AlterarTela(MetroPanel container, Control tela)
        {
            container.Controls.Clear();
            tela.Size = new Size
            {
                Width = container.Width,
                Height = tela.Size.Height
            };
            container.Controls.Add(tela);
        }
    }
}
