namespace FogGerenciadorDeVendas.Telas.Controles.Vendas
{
    partial class Venda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_comanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lb_status_comanda = new MetroFramework.Controls.MetroLabel();
            this.lb_codigo_comanda = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lb_valor_total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.resultado_produtos_grid = new MetroFramework.Controls.MetroGrid();
            this.txt_porc_desconto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete_produto_selecionar = new System.Windows.Forms.Button();
            this.btn_fechar_venda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultado_produtos_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_comanda
            // 
            // 
            // 
            // 
            this.txt_comanda.CustomButton.Image = null;
            this.txt_comanda.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txt_comanda.CustomButton.Name = "";
            this.txt_comanda.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_comanda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_comanda.CustomButton.TabIndex = 1;
            this.txt_comanda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_comanda.CustomButton.UseSelectable = true;
            this.txt_comanda.CustomButton.Visible = false;
            this.txt_comanda.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_comanda.Lines = new string[0];
            this.txt_comanda.Location = new System.Drawing.Point(3, 84);
            this.txt_comanda.MaxLength = 32767;
            this.txt_comanda.Name = "txt_comanda";
            this.txt_comanda.PasswordChar = '\0';
            this.txt_comanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_comanda.SelectedText = "";
            this.txt_comanda.SelectionLength = 0;
            this.txt_comanda.SelectionStart = 0;
            this.txt_comanda.ShortcutsEnabled = true;
            this.txt_comanda.Size = new System.Drawing.Size(119, 28);
            this.txt_comanda.TabIndex = 0;
            this.txt_comanda.UseSelectable = true;
            this.txt_comanda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_comanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_comanda.Leave += new System.EventHandler(this.txt_comanda_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Comanda *";
            // 
            // lb_status_comanda
            // 
            this.lb_status_comanda.AutoSize = true;
            this.lb_status_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_status_comanda.Location = new System.Drawing.Point(813, 88);
            this.lb_status_comanda.Name = "lb_status_comanda";
            this.lb_status_comanda.Size = new System.Drawing.Size(0, 0);
            this.lb_status_comanda.TabIndex = 29;
            this.lb_status_comanda.UseCustomForeColor = true;
            // 
            // lb_codigo_comanda
            // 
            this.lb_codigo_comanda.AutoSize = true;
            this.lb_codigo_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_codigo_comanda.Location = new System.Drawing.Point(813, 56);
            this.lb_codigo_comanda.Name = "lb_codigo_comanda";
            this.lb_codigo_comanda.Size = new System.Drawing.Size(0, 0);
            this.lb_codigo_comanda.TabIndex = 28;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(614, 88);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 25);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Status:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(614, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Comanda:";
            // 
            // lb_valor_total
            // 
            this.lb_valor_total.AutoSize = true;
            this.lb_valor_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_valor_total.Location = new System.Drawing.Point(813, 161);
            this.lb_valor_total.Name = "lb_valor_total";
            this.lb_valor_total.Size = new System.Drawing.Size(67, 25);
            this.lb_valor_total.TabIndex = 31;
            this.lb_valor_total.Text = "R$ 0,00";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(614, 163);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Total:";
            // 
            // resultado_produtos_grid
            // 
            this.resultado_produtos_grid.AllowUserToAddRows = false;
            this.resultado_produtos_grid.AllowUserToDeleteRows = false;
            this.resultado_produtos_grid.AllowUserToResizeRows = false;
            this.resultado_produtos_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultado_produtos_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultado_produtos_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultado_produtos_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado_produtos_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultado_produtos_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.resultado_produtos_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultado_produtos_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.resultado_produtos_grid.EnableHeadersVisualStyles = false;
            this.resultado_produtos_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultado_produtos_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultado_produtos_grid.Location = new System.Drawing.Point(3, 120);
            this.resultado_produtos_grid.MultiSelect = false;
            this.resultado_produtos_grid.Name = "resultado_produtos_grid";
            this.resultado_produtos_grid.ReadOnly = true;
            this.resultado_produtos_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.resultado_produtos_grid.RowHeadersVisible = false;
            this.resultado_produtos_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resultado_produtos_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultado_produtos_grid.Size = new System.Drawing.Size(596, 344);
            this.resultado_produtos_grid.TabIndex = 32;
            this.resultado_produtos_grid.DataSourceChanged += new System.EventHandler(this.resultado_produtos_grid_DataSourceChanged);
            this.resultado_produtos_grid.SelectionChanged += new System.EventHandler(this.resultado_produtos_grid_SelectionChanged);
            // 
            // txt_porc_desconto
            // 
            // 
            // 
            // 
            this.txt_porc_desconto.CustomButton.Image = null;
            this.txt_porc_desconto.CustomButton.Location = new System.Drawing.Point(41, 2);
            this.txt_porc_desconto.CustomButton.Name = "";
            this.txt_porc_desconto.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_porc_desconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_porc_desconto.CustomButton.TabIndex = 1;
            this.txt_porc_desconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_porc_desconto.CustomButton.UseSelectable = true;
            this.txt_porc_desconto.CustomButton.Visible = false;
            this.txt_porc_desconto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_porc_desconto.Lines = new string[] {
        "0"};
            this.txt_porc_desconto.Location = new System.Drawing.Point(813, 117);
            this.txt_porc_desconto.MaxLength = 32767;
            this.txt_porc_desconto.Name = "txt_porc_desconto";
            this.txt_porc_desconto.PasswordChar = '\0';
            this.txt_porc_desconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_porc_desconto.SelectedText = "";
            this.txt_porc_desconto.SelectionLength = 0;
            this.txt_porc_desconto.SelectionStart = 0;
            this.txt_porc_desconto.ShortcutsEnabled = true;
            this.txt_porc_desconto.Size = new System.Drawing.Size(67, 28);
            this.txt_porc_desconto.TabIndex = 2;
            this.txt_porc_desconto.Text = "0";
            this.txt_porc_desconto.UseSelectable = true;
            this.txt_porc_desconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_porc_desconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_porc_desconto.Leave += new System.EventHandler(this.txt_porc_desconto_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(614, 119);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 25);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "% de desconto:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(886, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(26, 25);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "%";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 10);
            this.panel1.TabIndex = 39;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(8, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(150, 25);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Fechar consumo";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 39);
            this.panel2.TabIndex = 40;
            // 
            // btn_delete_produto_selecionar
            // 
            this.btn_delete_produto_selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_produto_selecionar.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_produto_selecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete_produto_selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_produto_selecionar.Enabled = false;
            this.btn_delete_produto_selecionar.FlatAppearance.BorderSize = 0;
            this.btn_delete_produto_selecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_produto_selecionar.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_delete_produto_selecionar.Image = global::FogGerenciadorDeVendas.Properties.Resources.minus_circle_solid_25;
            this.btn_delete_produto_selecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_produto_selecionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete_produto_selecionar.Location = new System.Drawing.Point(8, 470);
            this.btn_delete_produto_selecionar.Name = "btn_delete_produto_selecionar";
            this.btn_delete_produto_selecionar.Size = new System.Drawing.Size(164, 40);
            this.btn_delete_produto_selecionar.TabIndex = 1;
            this.btn_delete_produto_selecionar.Text = "       Remover item";
            this.btn_delete_produto_selecionar.UseVisualStyleBackColor = false;
            this.btn_delete_produto_selecionar.Click += new System.EventHandler(this.btn_delete_produto_selecionar_Click);
            // 
            // btn_fechar_venda
            // 
            this.btn_fechar_venda.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar_venda.FlatAppearance.BorderSize = 0;
            this.btn_fechar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_venda.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_fechar_venda.Image = global::FogGerenciadorDeVendas.Properties.Resources.dollar_sign_solid_10px;
            this.btn_fechar_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar_venda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_fechar_venda.Location = new System.Drawing.Point(754, 208);
            this.btn_fechar_venda.Name = "btn_fechar_venda";
            this.btn_fechar_venda.Size = new System.Drawing.Size(158, 40);
            this.btn_fechar_venda.TabIndex = 3;
            this.btn_fechar_venda.Text = "       Fechar consumo";
            this.btn_fechar_venda.UseVisualStyleBackColor = false;
            this.btn_fechar_venda.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_fechar_venda);
            this.Controls.Add(this.btn_delete_produto_selecionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_porc_desconto);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.resultado_produtos_grid);
            this.Controls.Add(this.lb_valor_total);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lb_status_comanda);
            this.Controls.Add(this.lb_codigo_comanda);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_comanda);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "Venda";
            this.Size = new System.Drawing.Size(947, 534);
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultado_produtos_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_comanda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lb_status_comanda;
        private MetroFramework.Controls.MetroLabel lb_codigo_comanda;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lb_valor_total;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid resultado_produtos_grid;
        private MetroFramework.Controls.MetroTextBox txt_porc_desconto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete_produto_selecionar;
        private System.Windows.Forms.Button btn_fechar_venda;
    }
}
