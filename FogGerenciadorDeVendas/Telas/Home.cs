using System;
using System.Drawing;
using FogGerenciadorDeVendas.Extensoes;
using MetroFramework.Forms;
using System.Windows.Forms;
using Unity;

namespace FogGerenciadorDeVendas
{
    public partial class Home : MetroForm
    {
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
        //    ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        //    rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
        //    e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {  // Trap WM_NCHITTEST
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;  // HTCAPTION
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17; // HTBOTTOMRIGHT
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        public Home()
        {
            InitializeComponent();
            this.SetBevel(false);
            //var menu = Program.container.Resolve<Menu>();
            //menu.MdiParent = this;
            //menu.FormBorderStyle = FormBorderStyle.None;
            //menu.Dock = DockStyle.Fill;
            //menu.Show();
        }

        private void btn_novo_consumo_Click(object sender, System.EventArgs e)
        {
            ExibirDetalheMenu();
            panel_detalhe_menu.Height = btn_novo_consumo.Height;
            panel_detalhe_menu.Top = btn_novo_consumo.Top;
            var novoConsumo = Program.container.Resolve<Telas.Controles.Consumos.Cadastrar>();
            novoConsumo.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(novoConsumo);
        }

        private void btn_pagamento_Click(object sender, System.EventArgs e)
        {
            ExibirDetalheMenu();
            panel_detalhe_menu.Height = btn_pagamento.Height;
            panel_detalhe_menu.Top = btn_pagamento.Top;
            var venda = Program.container.Resolve<Telas.Controles.Vendas.Venda>();
            venda.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(venda);
        }

        private void btn_produtos_Click(object sender, System.EventArgs e)
        {
            ExibirDetalheMenu();
            panel_detalhe_menu.Height = btn_produtos.Height;
            panel_detalhe_menu.Top = btn_produtos.Top;
            var produtos = Program.container.Resolve<Telas.Controles.Produtos.Produtos>();
            produtos.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(produtos);
        }

        private void ExibirDetalheMenu()
        {
            panel_detalhe_menu.Visible = true;
            panel_detalhe_menu.BringToFront();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
           Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                panel_principal.Controls[0].Size = panel_principal.Size;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                panel_principal.Controls[0].Size = panel_principal.Size;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Resize(object sender, EventArgs e)
        {
            panel_principal.Controls[0].Size = panel_principal.Size;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_rel_venda_Click(object sender, EventArgs e)
        {
            ExibirDetalheMenu();
            panel_detalhe_menu.Height = btn_rel_venda.Height;
            panel_detalhe_menu.Top = btn_rel_venda.Top;
            var produtos = Program.container.Resolve<Telas.Controles.Relatorios.RelatorioDeVenda>();
            produtos.Size = panel_principal.Size;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(produtos);
        }
    }
}
