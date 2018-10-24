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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_comanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_valor_entrada = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lb_status_comanda = new MetroFramework.Controls.MetroLabel();
            this.lb_codigo_comanda = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lb_valor_total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.resultado_produtos_grid = new MetroFramework.Controls.MetroGrid();
            this.txt_porc_desconto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_delete_produto_selecionar = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn_fechar_venda = new MetroFramework.Controls.MetroButton();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultado_produtos_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroLabel4);
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(885, 42);
            this.metroTile1.TabIndex = 14;
            this.metroTile1.Text = "Fechamento de venda";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(199, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Fechamento de venda";
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
            this.txt_comanda.Location = new System.Drawing.Point(3, 73);
            this.txt_comanda.MaxLength = 32767;
            this.txt_comanda.Name = "txt_comanda";
            this.txt_comanda.PasswordChar = '\0';
            this.txt_comanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_comanda.SelectedText = "";
            this.txt_comanda.SelectionLength = 0;
            this.txt_comanda.SelectionStart = 0;
            this.txt_comanda.ShortcutsEnabled = true;
            this.txt_comanda.Size = new System.Drawing.Size(119, 28);
            this.txt_comanda.TabIndex = 16;
            this.txt_comanda.UseSelectable = true;
            this.txt_comanda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_comanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_comanda.Leave += new System.EventHandler(this.txt_comanda_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Comanda *";
            // 
            // txt_valor_entrada
            // 
            // 
            // 
            // 
            this.txt_valor_entrada.CustomButton.Image = null;
            this.txt_valor_entrada.CustomButton.Location = new System.Drawing.Point(111, 2);
            this.txt_valor_entrada.CustomButton.Name = "";
            this.txt_valor_entrada.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_valor_entrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_valor_entrada.CustomButton.TabIndex = 1;
            this.txt_valor_entrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_valor_entrada.CustomButton.UseSelectable = true;
            this.txt_valor_entrada.CustomButton.Visible = false;
            this.txt_valor_entrada.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_valor_entrada.Lines = new string[0];
            this.txt_valor_entrada.Location = new System.Drawing.Point(711, 104);
            this.txt_valor_entrada.MaxLength = 32767;
            this.txt_valor_entrada.Name = "txt_valor_entrada";
            this.txt_valor_entrada.PasswordChar = '\0';
            this.txt_valor_entrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_valor_entrada.SelectedText = "";
            this.txt_valor_entrada.SelectionLength = 0;
            this.txt_valor_entrada.SelectionStart = 0;
            this.txt_valor_entrada.ShortcutsEnabled = true;
            this.txt_valor_entrada.Size = new System.Drawing.Size(137, 28);
            this.txt_valor_entrada.TabIndex = 18;
            this.txt_valor_entrada.UseSelectable = true;
            this.txt_valor_entrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_valor_entrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_valor_entrada.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.txt_valor_entrada.Leave += new System.EventHandler(this.txt_valor_entrada_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(555, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(141, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Valor da Entrada:";
            // 
            // lb_status_comanda
            // 
            this.lb_status_comanda.AutoSize = true;
            this.lb_status_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_status_comanda.Location = new System.Drawing.Point(711, 78);
            this.lb_status_comanda.Name = "lb_status_comanda";
            this.lb_status_comanda.Size = new System.Drawing.Size(0, 0);
            this.lb_status_comanda.TabIndex = 29;
            // 
            // lb_codigo_comanda
            // 
            this.lb_codigo_comanda.AutoSize = true;
            this.lb_codigo_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_codigo_comanda.Location = new System.Drawing.Point(657, 45);
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
            this.metroLabel6.Location = new System.Drawing.Point(555, 76);
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
            this.metroLabel5.Location = new System.Drawing.Point(555, 45);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 25);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Comanda:";
            // 
            // lb_valor_total
            // 
            this.lb_valor_total.AutoSize = true;
            this.lb_valor_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_valor_total.Location = new System.Drawing.Point(711, 182);
            this.lb_valor_total.Name = "lb_valor_total";
            this.lb_valor_total.Size = new System.Drawing.Size(67, 25);
            this.lb_valor_total.TabIndex = 31;
            this.lb_valor_total.Text = "R$ 0,00";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(555, 182);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultado_produtos_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultado_produtos_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultado_produtos_grid.EnableHeadersVisualStyles = false;
            this.resultado_produtos_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultado_produtos_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultado_produtos_grid.Location = new System.Drawing.Point(3, 107);
            this.resultado_produtos_grid.MultiSelect = false;
            this.resultado_produtos_grid.Name = "resultado_produtos_grid";
            this.resultado_produtos_grid.ReadOnly = true;
            this.resultado_produtos_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.resultado_produtos_grid.RowHeadersVisible = false;
            this.resultado_produtos_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resultado_produtos_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultado_produtos_grid.Size = new System.Drawing.Size(520, 424);
            this.resultado_produtos_grid.TabIndex = 32;
            this.resultado_produtos_grid.DataSourceChanged += new System.EventHandler(this.resultado_produtos_grid_DataSourceChanged);
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
            this.txt_porc_desconto.Lines = new string[0];
            this.txt_porc_desconto.Location = new System.Drawing.Point(711, 138);
            this.txt_porc_desconto.MaxLength = 32767;
            this.txt_porc_desconto.Name = "txt_porc_desconto";
            this.txt_porc_desconto.PasswordChar = '\0';
            this.txt_porc_desconto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_porc_desconto.SelectedText = "";
            this.txt_porc_desconto.SelectionLength = 0;
            this.txt_porc_desconto.SelectionStart = 0;
            this.txt_porc_desconto.ShortcutsEnabled = true;
            this.txt_porc_desconto.Size = new System.Drawing.Size(67, 28);
            this.txt_porc_desconto.TabIndex = 34;
            this.txt_porc_desconto.UseSelectable = true;
            this.txt_porc_desconto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_porc_desconto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_porc_desconto.Leave += new System.EventHandler(this.txt_porc_desconto_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(555, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 25);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "% de desconto:";
            // 
            // btn_delete_produto_selecionar
            // 
            this.btn_delete_produto_selecionar.Location = new System.Drawing.Point(475, 78);
            this.btn_delete_produto_selecionar.Name = "btn_delete_produto_selecionar";
            this.btn_delete_produto_selecionar.Size = new System.Drawing.Size(48, 23);
            this.btn_delete_produto_selecionar.TabIndex = 35;
            this.btn_delete_produto_selecionar.Text = "delete";
            this.btn_delete_produto_selecionar.UseSelectable = true;
            this.btn_delete_produto_selecionar.Click += new System.EventHandler(this.btn_delete_produto_selecionar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(784, 141);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(26, 25);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "%";
            // 
            // btn_fechar_venda
            // 
            this.btn_fechar_venda.Enabled = false;
            this.btn_fechar_venda.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_fechar_venda.Location = new System.Drawing.Point(717, 261);
            this.btn_fechar_venda.Name = "btn_fechar_venda";
            this.btn_fechar_venda.Size = new System.Drawing.Size(131, 40);
            this.btn_fechar_venda.TabIndex = 37;
            this.btn_fechar_venda.Text = "Fechar venda";
            this.btn_fechar_venda.UseSelectable = true;
            this.btn_fechar_venda.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_fechar_venda);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btn_delete_produto_selecionar);
            this.Controls.Add(this.txt_porc_desconto);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.resultado_produtos_grid);
            this.Controls.Add(this.lb_valor_total);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lb_status_comanda);
            this.Controls.Add(this.lb_codigo_comanda);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_valor_entrada);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_comanda);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Venda";
            this.Size = new System.Drawing.Size(885, 534);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultado_produtos_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_comanda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_valor_entrada;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lb_status_comanda;
        private MetroFramework.Controls.MetroLabel lb_codigo_comanda;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lb_valor_total;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid resultado_produtos_grid;
        private MetroFramework.Controls.MetroTextBox txt_porc_desconto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_delete_produto_selecionar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btn_fechar_venda;
    }
}
