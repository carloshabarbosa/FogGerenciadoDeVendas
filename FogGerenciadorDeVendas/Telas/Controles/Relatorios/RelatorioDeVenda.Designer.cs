namespace FogGerenciadorDeVendas.Telas.Controles.Relatorios
{
    partial class RelatorioDeVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioDeVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.data_de = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.data_ate = new MetroFramework.Controls.MetroDateTime();
            this.btn_fechar_venda = new System.Windows.Forms.Button();
            this.hora_de = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.minuto_de = new MetroFramework.Controls.MetroTextBox();
            this.minuto_ate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.hora_ate = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 10);
            this.panel1.TabIndex = 42;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(8, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 25);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Relatório de venda";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 39);
            this.panel2.TabIndex = 43;
            // 
            // data_de
            // 
            this.data_de.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_de.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_de.Location = new System.Drawing.Point(17, 92);
            this.data_de.MinimumSize = new System.Drawing.Size(0, 29);
            this.data_de.Name = "data_de";
            this.data_de.Size = new System.Drawing.Size(107, 29);
            this.data_de.TabIndex = 44;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(17, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 25);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "De:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(237, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 25);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Até:";
            // 
            // data_ate
            // 
            this.data_ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_ate.Location = new System.Drawing.Point(237, 92);
            this.data_ate.MinimumSize = new System.Drawing.Size(0, 29);
            this.data_ate.Name = "data_ate";
            this.data_ate.Size = new System.Drawing.Size(107, 29);
            this.data_ate.TabIndex = 47;
            // 
            // btn_fechar_venda
            // 
            this.btn_fechar_venda.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_venda.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_fechar_venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar_venda.Image")));
            this.btn_fechar_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar_venda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_fechar_venda.Location = new System.Drawing.Point(472, 81);
            this.btn_fechar_venda.Name = "btn_fechar_venda";
            this.btn_fechar_venda.Size = new System.Drawing.Size(183, 40);
            this.btn_fechar_venda.TabIndex = 50;
            this.btn_fechar_venda.Text = "      Gerar Relatório";
            this.btn_fechar_venda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fechar_venda.UseVisualStyleBackColor = false;
            this.btn_fechar_venda.Click += new System.EventHandler(this.btn_fechar_venda_Click);
            // 
            // hora_de
            // 
            // 
            // 
            // 
            this.hora_de.CustomButton.Image = null;
            this.hora_de.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.hora_de.CustomButton.Name = "";
            this.hora_de.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.hora_de.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hora_de.CustomButton.TabIndex = 1;
            this.hora_de.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hora_de.CustomButton.UseSelectable = true;
            this.hora_de.CustomButton.Visible = false;
            this.hora_de.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.hora_de.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.hora_de.Lines = new string[] {
        "00"};
            this.hora_de.Location = new System.Drawing.Point(130, 93);
            this.hora_de.MaxLength = 2;
            this.hora_de.Name = "hora_de";
            this.hora_de.PasswordChar = '\0';
            this.hora_de.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hora_de.SelectedText = "";
            this.hora_de.SelectionLength = 0;
            this.hora_de.SelectionStart = 0;
            this.hora_de.ShortcutsEnabled = true;
            this.hora_de.Size = new System.Drawing.Size(36, 28);
            this.hora_de.TabIndex = 51;
            this.hora_de.Text = "00";
            this.hora_de.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hora_de.UseCustomForeColor = true;
            this.hora_de.UseSelectable = true;
            this.hora_de.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hora_de.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.hora_de.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(165, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 25);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = ":";
            // 
            // minuto_de
            // 
            // 
            // 
            // 
            this.minuto_de.CustomButton.Image = null;
            this.minuto_de.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.minuto_de.CustomButton.Name = "";
            this.minuto_de.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.minuto_de.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minuto_de.CustomButton.TabIndex = 1;
            this.minuto_de.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minuto_de.CustomButton.UseSelectable = true;
            this.minuto_de.CustomButton.Visible = false;
            this.minuto_de.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.minuto_de.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.minuto_de.Lines = new string[] {
        "00"};
            this.minuto_de.Location = new System.Drawing.Point(179, 93);
            this.minuto_de.MaxLength = 2;
            this.minuto_de.Name = "minuto_de";
            this.minuto_de.PasswordChar = '\0';
            this.minuto_de.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minuto_de.SelectedText = "";
            this.minuto_de.SelectionLength = 0;
            this.minuto_de.SelectionStart = 0;
            this.minuto_de.ShortcutsEnabled = true;
            this.minuto_de.Size = new System.Drawing.Size(36, 28);
            this.minuto_de.TabIndex = 53;
            this.minuto_de.Text = "00";
            this.minuto_de.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuto_de.UseCustomForeColor = true;
            this.minuto_de.UseSelectable = true;
            this.minuto_de.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minuto_de.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.minuto_de.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuto_de_KeyPress);
            // 
            // minuto_ate
            // 
            // 
            // 
            // 
            this.minuto_ate.CustomButton.Image = null;
            this.minuto_ate.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.minuto_ate.CustomButton.Name = "";
            this.minuto_ate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.minuto_ate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.minuto_ate.CustomButton.TabIndex = 1;
            this.minuto_ate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.minuto_ate.CustomButton.UseSelectable = true;
            this.minuto_ate.CustomButton.Visible = false;
            this.minuto_ate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.minuto_ate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.minuto_ate.Lines = new string[] {
        "00"};
            this.minuto_ate.Location = new System.Drawing.Point(399, 93);
            this.minuto_ate.MaxLength = 32767;
            this.minuto_ate.Name = "minuto_ate";
            this.minuto_ate.PasswordChar = '\0';
            this.minuto_ate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minuto_ate.SelectedText = "";
            this.minuto_ate.SelectionLength = 0;
            this.minuto_ate.SelectionStart = 0;
            this.minuto_ate.ShortcutsEnabled = true;
            this.minuto_ate.Size = new System.Drawing.Size(36, 28);
            this.minuto_ate.TabIndex = 56;
            this.minuto_ate.Text = "00";
            this.minuto_ate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuto_ate.UseCustomForeColor = true;
            this.minuto_ate.UseSelectable = true;
            this.minuto_ate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.minuto_ate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.minuto_ate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuto_ate_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(385, 93);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(16, 25);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = ":";
            // 
            // hora_ate
            // 
            // 
            // 
            // 
            this.hora_ate.CustomButton.Image = null;
            this.hora_ate.CustomButton.Location = new System.Drawing.Point(10, 2);
            this.hora_ate.CustomButton.Name = "";
            this.hora_ate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.hora_ate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hora_ate.CustomButton.TabIndex = 1;
            this.hora_ate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hora_ate.CustomButton.UseSelectable = true;
            this.hora_ate.CustomButton.Visible = false;
            this.hora_ate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.hora_ate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.hora_ate.Lines = new string[] {
        "00"};
            this.hora_ate.Location = new System.Drawing.Point(350, 93);
            this.hora_ate.MaxLength = 32767;
            this.hora_ate.Name = "hora_ate";
            this.hora_ate.PasswordChar = '\0';
            this.hora_ate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hora_ate.SelectedText = "";
            this.hora_ate.SelectionLength = 0;
            this.hora_ate.SelectionStart = 0;
            this.hora_ate.ShortcutsEnabled = true;
            this.hora_ate.Size = new System.Drawing.Size(36, 28);
            this.hora_ate.TabIndex = 54;
            this.hora_ate.Text = "00";
            this.hora_ate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hora_ate.UseCustomForeColor = true;
            this.hora_ate.UseSelectable = true;
            this.hora_ate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hora_ate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.hora_ate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hora_ate_KeyPress);
            // 
            // RelatorioDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minuto_ate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.hora_ate);
            this.Controls.Add(this.minuto_de);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.hora_de);
            this.Controls.Add(this.btn_fechar_venda);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.data_ate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.data_de);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel2);
            this.Name = "RelatorioDeVenda";
            this.Size = new System.Drawing.Size(699, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroDateTime data_de;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime data_ate;
        private System.Windows.Forms.Button btn_fechar_venda;
        private MetroFramework.Controls.MetroTextBox hora_de;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox minuto_de;
        private MetroFramework.Controls.MetroTextBox minuto_ate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox hora_ate;
    }
}
