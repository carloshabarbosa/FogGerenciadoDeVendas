using System.Windows.Forms;

namespace FogGerenciadorDeVendas
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel_detalhe_menu = new System.Windows.Forms.Panel();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_pagamento = new System.Windows.Forms.Button();
            this.btn_novo_consumo = new System.Windows.Forms.Button();
            this.panel_principal = new MetroFramework.Controls.MetroPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_rel_venda = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.btn_rel_venda);
            this.metroPanel1.Controls.Add(this.panel_detalhe_menu);
            this.metroPanel1.Controls.Add(this.btn_produtos);
            this.metroPanel1.Controls.Add(this.btn_pagamento);
            this.metroPanel1.Controls.Add(this.btn_novo_consumo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // panel_detalhe_menu
            // 
            this.panel_detalhe_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            resources.ApplyResources(this.panel_detalhe_menu, "panel_detalhe_menu");
            this.panel_detalhe_menu.Name = "panel_detalhe_menu";
            // 
            // btn_produtos
            // 
            resources.ApplyResources(this.btn_produtos, "btn_produtos");
            this.btn_produtos.FlatAppearance.BorderSize = 0;
            this.btn_produtos.Image = global::FogGerenciadorDeVendas.Properties.Resources.clipboard_list_solid_25;
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // btn_pagamento
            // 
            resources.ApplyResources(this.btn_pagamento, "btn_pagamento");
            this.btn_pagamento.FlatAppearance.BorderSize = 0;
            this.btn_pagamento.Image = global::FogGerenciadorDeVendas.Properties.Resources.dollar_sign_solid_10px;
            this.btn_pagamento.Name = "btn_pagamento";
            this.btn_pagamento.UseVisualStyleBackColor = true;
            this.btn_pagamento.Click += new System.EventHandler(this.btn_pagamento_Click);
            // 
            // btn_novo_consumo
            // 
            resources.ApplyResources(this.btn_novo_consumo, "btn_novo_consumo");
            this.btn_novo_consumo.FlatAppearance.BorderSize = 0;
            this.btn_novo_consumo.Image = global::FogGerenciadorDeVendas.Properties.Resources.cart_plus_solid_25px;
            this.btn_novo_consumo.Name = "btn_novo_consumo";
            this.btn_novo_consumo.UseVisualStyleBackColor = true;
            this.btn_novo_consumo.Click += new System.EventHandler(this.btn_novo_consumo_Click);
            // 
            // panel_principal
            // 
            resources.ApplyResources(this.panel_principal, "panel_principal");
            this.panel_principal.HorizontalScrollbarBarColor = true;
            this.panel_principal.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_principal.HorizontalScrollbarSize = 10;
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.VerticalScrollbarBarColor = true;
            this.panel_principal.VerticalScrollbarHighlightOnWheel = false;
            this.panel_principal.VerticalScrollbarSize = 10;
            this.panel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_principal_Paint);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_rel_venda
            // 
            resources.ApplyResources(this.btn_rel_venda, "btn_rel_venda");
            this.btn_rel_venda.FlatAppearance.BorderSize = 0;
            this.btn_rel_venda.Name = "btn_rel_venda";
            this.btn_rel_venda.UseVisualStyleBackColor = true;
            this.btn_rel_venda.Click += new System.EventHandler(this.btn_rel_venda_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Home";
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel panel_principal;
        private Button btn_novo_consumo;
        private Button btn_produtos;
        private Button btn_pagamento;
        private Panel panel_detalhe_menu;
        private Button button2;
        private Button btn_rel_venda;
    }
}

