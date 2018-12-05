using System.Windows.Forms;

namespace FogGerenciadorDeVendas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_novo_consumo = new System.Windows.Forms.Button();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.panel_principal = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_novo_consumo
            // 
            resources.ApplyResources(this.btn_novo_consumo, "btn_novo_consumo");
            this.btn_novo_consumo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo_consumo.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.cart_plus_solid_1;
            this.btn_novo_consumo.Name = "btn_novo_consumo";
            this.btn_novo_consumo.UseVisualStyleBackColor = false;
            this.btn_novo_consumo.Click += new System.EventHandler(this.btn_novo_consumo_Click);
            // 
            // metroButton2
            // 
            resources.ApplyResources(this.metroButton2, "metroButton2");
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.dollar_sign_solid;
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            resources.ApplyResources(this.metroButton3, "metroButton3");
            this.metroButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroButton3.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.clipboard_list_solid;
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            resources.ApplyResources(this.metroButton4, "metroButton4");
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.UseSelectable = true;
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
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.Name = "metroLabel2";
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            // 
            // metroPanel1
            // 
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.btn_novo_consumo);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel_principal);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_novo_consumo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroPanel panel_principal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}