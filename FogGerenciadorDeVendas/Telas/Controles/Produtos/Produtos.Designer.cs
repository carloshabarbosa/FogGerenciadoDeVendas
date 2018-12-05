namespace FogGerenciadorDeVendas.Telas.Controles.Produtos
{
    partial class Produtos
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
            this.produtos_grid = new MetroFramework.Controls.MetroGrid();
            this.txt_codigo_nome = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add_produto = new System.Windows.Forms.Button();
            this.btn_edita_produto = new System.Windows.Forms.Button();
            this.btn_remover_produto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // produtos_grid
            // 
            this.produtos_grid.AllowUserToAddRows = false;
            this.produtos_grid.AllowUserToDeleteRows = false;
            this.produtos_grid.AllowUserToResizeRows = false;
            this.produtos_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtos_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produtos_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.produtos_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtos_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.produtos_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtos_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.produtos_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtos_grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.produtos_grid.EnableHeadersVisualStyles = false;
            this.produtos_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.produtos_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.produtos_grid.Location = new System.Drawing.Point(3, 99);
            this.produtos_grid.MultiSelect = false;
            this.produtos_grid.Name = "produtos_grid";
            this.produtos_grid.ReadOnly = true;
            this.produtos_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtos_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.produtos_grid.RowHeadersVisible = false;
            this.produtos_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.produtos_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtos_grid.Size = new System.Drawing.Size(753, 345);
            this.produtos_grid.TabIndex = 0;
            this.produtos_grid.SelectionChanged += new System.EventHandler(this.produtos_grid_SelectionChanged);
            // 
            // txt_codigo_nome
            // 
            // 
            // 
            // 
            this.txt_codigo_nome.CustomButton.Image = null;
            this.txt_codigo_nome.CustomButton.Location = new System.Drawing.Point(294, 2);
            this.txt_codigo_nome.CustomButton.Name = "";
            this.txt_codigo_nome.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_codigo_nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_codigo_nome.CustomButton.TabIndex = 1;
            this.txt_codigo_nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_codigo_nome.CustomButton.UseSelectable = true;
            this.txt_codigo_nome.CustomButton.Visible = false;
            this.txt_codigo_nome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_codigo_nome.Lines = new string[0];
            this.txt_codigo_nome.Location = new System.Drawing.Point(3, 59);
            this.txt_codigo_nome.MaxLength = 32767;
            this.txt_codigo_nome.Name = "txt_codigo_nome";
            this.txt_codigo_nome.PasswordChar = '\0';
            this.txt_codigo_nome.PromptText = "Pesquise por código ou nome do produto";
            this.txt_codigo_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo_nome.SelectedText = "";
            this.txt_codigo_nome.SelectionLength = 0;
            this.txt_codigo_nome.SelectionStart = 0;
            this.txt_codigo_nome.ShortcutsEnabled = true;
            this.txt_codigo_nome.Size = new System.Drawing.Size(322, 30);
            this.txt_codigo_nome.TabIndex = 0;
            this.txt_codigo_nome.UseSelectable = true;
            this.txt_codigo_nome.WaterMark = "Pesquise por código ou nome do produto";
            this.txt_codigo_nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_codigo_nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo_nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_nome_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 10);
            this.panel1.TabIndex = 31;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(9, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 25);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Produtos";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 39);
            this.panel2.TabIndex = 41;
            // 
            // btn_add_produto
            // 
            this.btn_add_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_produto.FlatAppearance.BorderSize = 0;
            this.btn_add_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_produto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_add_produto.Image = global::FogGerenciadorDeVendas.Properties.Resources.plus_solid_25;
            this.btn_add_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_produto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_add_produto.Location = new System.Drawing.Point(333, 55);
            this.btn_add_produto.Name = "btn_add_produto";
            this.btn_add_produto.Size = new System.Drawing.Size(140, 35);
            this.btn_add_produto.TabIndex = 1;
            this.btn_add_produto.Text = "    Adicionar";
            this.btn_add_produto.UseVisualStyleBackColor = false;
            this.btn_add_produto.Click += new System.EventHandler(this.btn_add_produto_Click);
            // 
            // btn_edita_produto
            // 
            this.btn_edita_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edita_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_edita_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edita_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edita_produto.FlatAppearance.BorderSize = 0;
            this.btn_edita_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edita_produto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_edita_produto.Image = global::FogGerenciadorDeVendas.Properties.Resources.edit_solid_25;
            this.btn_edita_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edita_produto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_edita_produto.Location = new System.Drawing.Point(470, 55);
            this.btn_edita_produto.Name = "btn_edita_produto";
            this.btn_edita_produto.Size = new System.Drawing.Size(140, 35);
            this.btn_edita_produto.TabIndex = 2;
            this.btn_edita_produto.Text = "    Editar";
            this.btn_edita_produto.UseVisualStyleBackColor = false;
            this.btn_edita_produto.Click += new System.EventHandler(this.btn_edita_produto_Click);
            // 
            // btn_remover_produto
            // 
            this.btn_remover_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remover_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_remover_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_remover_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remover_produto.FlatAppearance.BorderSize = 0;
            this.btn_remover_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover_produto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.btn_remover_produto.Image = global::FogGerenciadorDeVendas.Properties.Resources.trash_alt_solid_25;
            this.btn_remover_produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover_produto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_remover_produto.Location = new System.Drawing.Point(616, 54);
            this.btn_remover_produto.Name = "btn_remover_produto";
            this.btn_remover_produto.Size = new System.Drawing.Size(140, 35);
            this.btn_remover_produto.TabIndex = 3;
            this.btn_remover_produto.Text = "    Excluir";
            this.btn_remover_produto.UseVisualStyleBackColor = false;
            this.btn_remover_produto.Click += new System.EventHandler(this.btn_remover_produto_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remover_produto);
            this.Controls.Add(this.btn_edita_produto);
            this.Controls.Add(this.btn_add_produto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_codigo_nome);
            this.Controls.Add(this.produtos_grid);
            this.Controls.Add(this.panel2);
            this.Name = "Produtos";
            this.Size = new System.Drawing.Size(759, 444);
            ((System.ComponentModel.ISupportInitialize)(this.produtos_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid produtos_grid;
        private MetroFramework.Controls.MetroTextBox txt_codigo_nome;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_add_produto;
        private System.Windows.Forms.Button btn_edita_produto;
        private System.Windows.Forms.Button btn_remover_produto;
    }
}
