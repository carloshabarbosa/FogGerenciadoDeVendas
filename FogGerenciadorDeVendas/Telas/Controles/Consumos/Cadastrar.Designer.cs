namespace FogGerenciadorDeVendas.Telas.Controles.Consumos
{
    partial class Cadastrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_comanda = new MetroFramework.Controls.MetroTextBox();
            this.txt_codigo_nome = new MetroFramework.Controls.MetroTextBox();
            this.txt_qtd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_adicionar_produto_comanda = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.selecionar_produtos_grid = new MetroFramework.Controls.MetroGrid();
            this.resultado_produtos_grid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lb_codigo_comanda = new MetroFramework.Controls.MetroLabel();
            this.lb_status_comanda = new MetroFramework.Controls.MetroLabel();
            this.btn_delete_produto_selecionar = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lb_valor_total = new MetroFramework.Controls.MetroLabel();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selecionar_produtos_grid)).BeginInit();
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
            this.metroTile1.Size = new System.Drawing.Size(936, 42);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "teste123";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Novo Consumo";
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
            this.txt_comanda.Location = new System.Drawing.Point(9, 86);
            this.txt_comanda.MaxLength = 32767;
            this.txt_comanda.Name = "txt_comanda";
            this.txt_comanda.PasswordChar = '\0';
            this.txt_comanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_comanda.SelectedText = "";
            this.txt_comanda.SelectionLength = 0;
            this.txt_comanda.SelectionStart = 0;
            this.txt_comanda.ShortcutsEnabled = true;
            this.txt_comanda.Size = new System.Drawing.Size(119, 28);
            this.txt_comanda.TabIndex = 12;
            this.txt_comanda.UseSelectable = true;
            this.txt_comanda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_comanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_comanda.Leave += new System.EventHandler(this.txt_comanda_Leave);
            // 
            // txt_codigo_nome
            // 
            // 
            // 
            // 
            this.txt_codigo_nome.CustomButton.Image = null;
            this.txt_codigo_nome.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txt_codigo_nome.CustomButton.Name = "";
            this.txt_codigo_nome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_codigo_nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_codigo_nome.CustomButton.TabIndex = 1;
            this.txt_codigo_nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_codigo_nome.CustomButton.UseSelectable = true;
            this.txt_codigo_nome.CustomButton.Visible = false;
            this.txt_codigo_nome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_codigo_nome.Lines = new string[0];
            this.txt_codigo_nome.Location = new System.Drawing.Point(9, 145);
            this.txt_codigo_nome.MaxLength = 32767;
            this.txt_codigo_nome.Name = "txt_codigo_nome";
            this.txt_codigo_nome.PasswordChar = '\0';
            this.txt_codigo_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_codigo_nome.SelectedText = "";
            this.txt_codigo_nome.SelectionLength = 0;
            this.txt_codigo_nome.SelectionStart = 0;
            this.txt_codigo_nome.ShortcutsEnabled = true;
            this.txt_codigo_nome.Size = new System.Drawing.Size(259, 28);
            this.txt_codigo_nome.TabIndex = 15;
            this.txt_codigo_nome.UseSelectable = true;
            this.txt_codigo_nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_codigo_nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo_nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyUp);
            // 
            // txt_qtd
            // 
            // 
            // 
            // 
            this.txt_qtd.CustomButton.Image = null;
            this.txt_qtd.CustomButton.Location = new System.Drawing.Point(59, 2);
            this.txt_qtd.CustomButton.Name = "";
            this.txt_qtd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_qtd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qtd.CustomButton.TabIndex = 1;
            this.txt_qtd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qtd.CustomButton.UseSelectable = true;
            this.txt_qtd.CustomButton.Visible = false;
            this.txt_qtd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_qtd.Lines = new string[] {
        "1"};
            this.txt_qtd.Location = new System.Drawing.Point(274, 145);
            this.txt_qtd.MaxLength = 32767;
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.PasswordChar = '\0';
            this.txt_qtd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qtd.SelectedText = "";
            this.txt_qtd.SelectionLength = 0;
            this.txt_qtd.SelectionStart = 0;
            this.txt_qtd.ShortcutsEnabled = true;
            this.txt_qtd.Size = new System.Drawing.Size(85, 28);
            this.txt_qtd.TabIndex = 17;
            this.txt_qtd.Text = "1";
            this.txt_qtd.UseSelectable = true;
            this.txt_qtd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qtd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qtd.TextChanged += new System.EventHandler(this.txt_qtd_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(274, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Qtd * ";
            // 
            // btn_adicionar_produto_comanda
            // 
            this.btn_adicionar_produto_comanda.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_adicionar_produto_comanda.Location = new System.Drawing.Point(369, 145);
            this.btn_adicionar_produto_comanda.Name = "btn_adicionar_produto_comanda";
            this.btn_adicionar_produto_comanda.Size = new System.Drawing.Size(46, 28);
            this.btn_adicionar_produto_comanda.TabIndex = 18;
            this.btn_adicionar_produto_comanda.Text = "+";
            this.btn_adicionar_produto_comanda.UseSelectable = true;
            this.btn_adicionar_produto_comanda.Click += new System.EventHandler(this.btn_adicionar_produto_comanda_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(9, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(232, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Código ou nome do produto";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Comanda *";
            // 
            // selecionar_produtos_grid
            // 
            this.selecionar_produtos_grid.AllowUserToAddRows = false;
            this.selecionar_produtos_grid.AllowUserToDeleteRows = false;
            this.selecionar_produtos_grid.AllowUserToResizeRows = false;
            this.selecionar_produtos_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selecionar_produtos_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selecionar_produtos_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selecionar_produtos_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selecionar_produtos_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.selecionar_produtos_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selecionar_produtos_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.selecionar_produtos_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selecionar_produtos_grid.DefaultCellStyle = dataGridViewCellStyle20;
            this.selecionar_produtos_grid.EnableHeadersVisualStyles = false;
            this.selecionar_produtos_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.selecionar_produtos_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selecionar_produtos_grid.Location = new System.Drawing.Point(9, 197);
            this.selecionar_produtos_grid.MultiSelect = false;
            this.selecionar_produtos_grid.Name = "selecionar_produtos_grid";
            this.selecionar_produtos_grid.ReadOnly = true;
            this.selecionar_produtos_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selecionar_produtos_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.selecionar_produtos_grid.RowHeadersVisible = false;
            this.selecionar_produtos_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.selecionar_produtos_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selecionar_produtos_grid.Size = new System.Drawing.Size(406, 296);
            this.selecionar_produtos_grid.TabIndex = 19;
            // 
            // resultado_produtos_grid
            // 
            this.resultado_produtos_grid.AllowUserToAddRows = false;
            this.resultado_produtos_grid.AllowUserToDeleteRows = false;
            this.resultado_produtos_grid.AllowUserToResizeRows = false;
            this.resultado_produtos_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultado_produtos_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultado_produtos_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultado_produtos_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado_produtos_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultado_produtos_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.resultado_produtos_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultado_produtos_grid.DefaultCellStyle = dataGridViewCellStyle23;
            this.resultado_produtos_grid.EnableHeadersVisualStyles = false;
            this.resultado_produtos_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultado_produtos_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultado_produtos_grid.Location = new System.Drawing.Point(494, 148);
            this.resultado_produtos_grid.MultiSelect = false;
            this.resultado_produtos_grid.Name = "resultado_produtos_grid";
            this.resultado_produtos_grid.ReadOnly = true;
            this.resultado_produtos_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultado_produtos_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.resultado_produtos_grid.RowHeadersVisible = false;
            this.resultado_produtos_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resultado_produtos_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultado_produtos_grid.Size = new System.Drawing.Size(421, 303);
            this.resultado_produtos_grid.TabIndex = 20;
            this.resultado_produtos_grid.DataSourceChanged += new System.EventHandler(this.resultado_produtos_grid_DataSourceChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(494, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 25);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Comanda:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(675, 58);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 25);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Status:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(494, 117);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(280, 25);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Produtos adicionados na comanda:";
            // 
            // lb_codigo_comanda
            // 
            this.lb_codigo_comanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_codigo_comanda.AutoSize = true;
            this.lb_codigo_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_codigo_comanda.Location = new System.Drawing.Point(590, 58);
            this.lb_codigo_comanda.Name = "lb_codigo_comanda";
            this.lb_codigo_comanda.Size = new System.Drawing.Size(0, 0);
            this.lb_codigo_comanda.TabIndex = 24;
            // 
            // lb_status_comanda
            // 
            this.lb_status_comanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_status_comanda.AutoSize = true;
            this.lb_status_comanda.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_status_comanda.Location = new System.Drawing.Point(742, 58);
            this.lb_status_comanda.Name = "lb_status_comanda";
            this.lb_status_comanda.Size = new System.Drawing.Size(0, 0);
            this.lb_status_comanda.TabIndex = 25;
            // 
            // btn_delete_produto_selecionar
            // 
            this.btn_delete_produto_selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_produto_selecionar.Location = new System.Drawing.Point(826, 119);
            this.btn_delete_produto_selecionar.Name = "btn_delete_produto_selecionar";
            this.btn_delete_produto_selecionar.Size = new System.Drawing.Size(48, 23);
            this.btn_delete_produto_selecionar.TabIndex = 26;
            this.btn_delete_produto_selecionar.Text = "delete";
            this.btn_delete_produto_selecionar.UseSelectable = true;
            this.btn_delete_produto_selecionar.Click += new System.EventHandler(this.btn_delete_produto_selecionar_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(494, 454);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Total:";
            // 
            // lb_valor_total
            // 
            this.lb_valor_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_valor_total.AutoSize = true;
            this.lb_valor_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_valor_total.Location = new System.Drawing.Point(810, 454);
            this.lb_valor_total.Name = "lb_valor_total";
            this.lb_valor_total.Size = new System.Drawing.Size(67, 25);
            this.lb_valor_total.TabIndex = 28;
            this.lb_valor_total.Text = "R$ 0,00";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_valor_total);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btn_delete_produto_selecionar);
            this.Controls.Add(this.lb_status_comanda);
            this.Controls.Add(this.lb_codigo_comanda);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.resultado_produtos_grid);
            this.Controls.Add(this.selecionar_produtos_grid);
            this.Controls.Add(this.btn_adicionar_produto_comanda);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_codigo_nome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txt_comanda);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Cadastrar";
            this.Size = new System.Drawing.Size(936, 496);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selecionar_produtos_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado_produtos_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_comanda;
        private MetroFramework.Controls.MetroTextBox txt_codigo_nome;
        private MetroFramework.Controls.MetroTextBox txt_qtd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_adicionar_produto_comanda;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid selecionar_produtos_grid;
        private MetroFramework.Controls.MetroGrid resultado_produtos_grid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lb_codigo_comanda;
        private MetroFramework.Controls.MetroLabel lb_status_comanda;
        private MetroFramework.Controls.MetroButton btn_delete_produto_selecionar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lb_valor_total;
    }
}
