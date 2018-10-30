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
            this.btn_novo_consumo = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.panel_principal = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn_novo_consumo
            // 
            this.btn_novo_consumo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo_consumo.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.cart_plus_solid_1;
            this.btn_novo_consumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_novo_consumo.Location = new System.Drawing.Point(5, 30);
            this.btn_novo_consumo.Name = "btn_novo_consumo";
            this.btn_novo_consumo.Size = new System.Drawing.Size(115, 79);
            this.btn_novo_consumo.TabIndex = 0;
            this.btn_novo_consumo.UseCustomBackColor = true;
            this.btn_novo_consumo.UseCustomForeColor = true;
            this.btn_novo_consumo.UseSelectable = true;
            this.btn_novo_consumo.Click += new System.EventHandler(this.btn_novo_consumo_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.dollar_sign_solid;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.Location = new System.Drawing.Point(5, 148);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(115, 79);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroButton3.BackgroundImage = global::FogGerenciadorDeVendas.Properties.Resources.clipboard_list_solid;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton3.Location = new System.Drawing.Point(5, 268);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(115, 79);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(5, 392);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(115, 79);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_principal.BackgroundImage")));
            this.panel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_principal.HorizontalScrollbarBarColor = true;
            this.panel_principal.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_principal.HorizontalScrollbarSize = 10;
            this.panel_principal.Location = new System.Drawing.Point(126, 30);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(765, 457);
            this.panel_principal.TabIndex = 4;
            this.panel_principal.VerticalScrollbarBarColor = true;
            this.panel_principal.VerticalScrollbarHighlightOnWheel = false;
            this.panel_principal.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Consumo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 230);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Vendas";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 350);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Produtos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 507);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_novo_consumo);
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Menu";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_novo_consumo;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroPanel panel_principal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}