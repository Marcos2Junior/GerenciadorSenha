namespace GerenciadorSenha
{
    partial class FrmExibeSenha
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.panel_exibe_senha = new System.Windows.Forms.Panel();
            this.txt_ultimaVisualizacaoSenha = new System.Windows.Forms.TextBox();
            this.txt_dataCadastroSenha = new System.Windows.Forms.TextBox();
            this.txt_descricaoSenha = new System.Windows.Forms.TextBox();
            this.txt_chaveSenha = new System.Windows.Forms.TextBox();
            this.txt_nomeSenha = new System.Windows.Forms.TextBox();
            this.txt_idSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bloqueia_tela = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_nomeSenha = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_bloqueio = new System.Windows.Forms.Label();
            this.pb_novaSenha = new System.Windows.Forms.PictureBox();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.pb_ajuda = new System.Windows.Forms.PictureBox();
            this.pb_visualizarAcesso = new System.Windows.Forms.PictureBox();
            this.panel_exibe = new System.Windows.Forms.Panel();
            this.panel_exibe_senha.SuspendLayout();
            this.panel_bloqueia_tela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ajuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visualizarAcesso)).BeginInit();
            this.panel_exibe.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisa.Location = new System.Drawing.Point(16, 75);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(357, 29);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // panel_exibe_senha
            // 
            this.panel_exibe_senha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_exibe_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_exibe_senha.Controls.Add(this.txt_ultimaVisualizacaoSenha);
            this.panel_exibe_senha.Controls.Add(this.txt_dataCadastroSenha);
            this.panel_exibe_senha.Controls.Add(this.txt_descricaoSenha);
            this.panel_exibe_senha.Controls.Add(this.txt_chaveSenha);
            this.panel_exibe_senha.Controls.Add(this.txt_nomeSenha);
            this.panel_exibe_senha.Controls.Add(this.txt_idSenha);
            this.panel_exibe_senha.Controls.Add(this.label6);
            this.panel_exibe_senha.Controls.Add(this.label5);
            this.panel_exibe_senha.Controls.Add(this.label4);
            this.panel_exibe_senha.Controls.Add(this.label3);
            this.panel_exibe_senha.Controls.Add(this.label2);
            this.panel_exibe_senha.Controls.Add(this.label1);
            this.panel_exibe_senha.Location = new System.Drawing.Point(15, 182);
            this.panel_exibe_senha.Name = "panel_exibe_senha";
            this.panel_exibe_senha.Size = new System.Drawing.Size(357, 248);
            this.panel_exibe_senha.TabIndex = 2;
            // 
            // txt_ultimaVisualizacaoSenha
            // 
            this.txt_ultimaVisualizacaoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ultimaVisualizacaoSenha.Location = new System.Drawing.Point(191, 210);
            this.txt_ultimaVisualizacaoSenha.Name = "txt_ultimaVisualizacaoSenha";
            this.txt_ultimaVisualizacaoSenha.Size = new System.Drawing.Size(143, 16);
            this.txt_ultimaVisualizacaoSenha.TabIndex = 5;
            this.txt_ultimaVisualizacaoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dataCadastroSenha
            // 
            this.txt_dataCadastroSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dataCadastroSenha.Location = new System.Drawing.Point(21, 210);
            this.txt_dataCadastroSenha.Name = "txt_dataCadastroSenha";
            this.txt_dataCadastroSenha.Size = new System.Drawing.Size(135, 16);
            this.txt_dataCadastroSenha.TabIndex = 4;
            this.txt_dataCadastroSenha.Text = "20/11/2020 14:50.22";
            this.txt_dataCadastroSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_descricaoSenha
            // 
            this.txt_descricaoSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descricaoSenha.Location = new System.Drawing.Point(21, 153);
            this.txt_descricaoSenha.Name = "txt_descricaoSenha";
            this.txt_descricaoSenha.Size = new System.Drawing.Size(313, 16);
            this.txt_descricaoSenha.TabIndex = 3;
            this.txt_descricaoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_chaveSenha
            // 
            this.txt_chaveSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_chaveSenha.Location = new System.Drawing.Point(21, 96);
            this.txt_chaveSenha.Name = "txt_chaveSenha";
            this.txt_chaveSenha.Size = new System.Drawing.Size(313, 16);
            this.txt_chaveSenha.TabIndex = 2;
            this.txt_chaveSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nomeSenha
            // 
            this.txt_nomeSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeSenha.Location = new System.Drawing.Point(191, 39);
            this.txt_nomeSenha.Name = "txt_nomeSenha";
            this.txt_nomeSenha.Size = new System.Drawing.Size(143, 16);
            this.txt_nomeSenha.TabIndex = 1;
            this.txt_nomeSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_idSenha
            // 
            this.txt_idSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_idSenha.Location = new System.Drawing.Point(21, 39);
            this.txt_idSenha.Name = "txt_idSenha";
            this.txt_idSenha.Size = new System.Drawing.Size(135, 16);
            this.txt_idSenha.TabIndex = 0;
            this.txt_idSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(191, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ultima visualização";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(191, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificação";
            // 
            // panel_bloqueia_tela
            // 
            this.panel_bloqueia_tela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bloqueia_tela.Controls.Add(this.label11);
            this.panel_bloqueia_tela.Controls.Add(this.panel1);
            this.panel_bloqueia_tela.Controls.Add(this.label10);
            this.panel_bloqueia_tela.Controls.Add(this.txt_senha);
            this.panel_bloqueia_tela.Controls.Add(this.label9);
            this.panel_bloqueia_tela.Controls.Add(this.label8);
            this.panel_bloqueia_tela.Controls.Add(this.label7);
            this.panel_bloqueia_tela.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bloqueia_tela.Location = new System.Drawing.Point(0, 0);
            this.panel_bloqueia_tela.Name = "panel_bloqueia_tela";
            this.panel_bloqueia_tela.Size = new System.Drawing.Size(450, 495);
            this.panel_bloqueia_tela.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(263, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Precisa de ajuda?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(28, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 3);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(49, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Esqueceu sua senha?";
            // 
            // txt_senha
            // 
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(113, 290);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(229, 29);
            this.txt_senha.TabIndex = 0;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(121, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Digite sua senha para liberar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(162, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Acesso bloqueado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(19, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(412, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gerenciador Senhas";
            // 
            // lb_nomeSenha
            // 
            this.lb_nomeSenha.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_nomeSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nomeSenha.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nomeSenha.FormattingEnabled = true;
            this.lb_nomeSenha.ItemHeight = 21;
            this.lb_nomeSenha.Location = new System.Drawing.Point(16, 105);
            this.lb_nomeSenha.Name = "lb_nomeSenha";
            this.lb_nomeSenha.Size = new System.Drawing.Size(357, 67);
            this.lb_nomeSenha.TabIndex = 1;
            this.lb_nomeSenha.SelectedIndexChanged += new System.EventHandler(this.lb_nomeSenha_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_bloqueio
            // 
            this.lbl_bloqueio.AutoSize = true;
            this.lbl_bloqueio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bloqueio.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_bloqueio.Location = new System.Drawing.Point(82, 442);
            this.lbl_bloqueio.Name = "lbl_bloqueio";
            this.lbl_bloqueio.Size = new System.Drawing.Size(233, 17);
            this.lbl_bloqueio.TabIndex = 6;
            this.lbl_bloqueio.Text = "Processando o desbloqueio da tela ...";
            // 
            // pb_novaSenha
            // 
            this.pb_novaSenha.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_novaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_novaSenha.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_novaSenha.Location = new System.Drawing.Point(89, 0);
            this.pb_novaSenha.Name = "pb_novaSenha";
            this.pb_novaSenha.Size = new System.Drawing.Size(89, 34);
            this.pb_novaSenha.TabIndex = 8;
            this.pb_novaSenha.TabStop = false;
            this.pb_novaSenha.Click += new System.EventHandler(this.pb_novaSenha_Click);
            // 
            // pb_editar
            // 
            this.pb_editar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pb_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_editar.Location = new System.Drawing.Point(0, 0);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(89, 34);
            this.pb_editar.TabIndex = 8;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_novaSenha_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Visualizar acessos";
            // 
            // panel_nav
            // 
            this.panel_nav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_nav.Controls.Add(this.pb_ajuda);
            this.panel_nav.Controls.Add(this.pb_visualizarAcesso);
            this.panel_nav.Controls.Add(this.pb_novaSenha);
            this.panel_nav.Controls.Add(this.pb_editar);
            this.panel_nav.Location = new System.Drawing.Point(16, 13);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(357, 38);
            this.panel_nav.TabIndex = 9;
            // 
            // pb_ajuda
            // 
            this.pb_ajuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_ajuda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_ajuda.Location = new System.Drawing.Point(267, 0);
            this.pb_ajuda.Name = "pb_ajuda";
            this.pb_ajuda.Size = new System.Drawing.Size(89, 34);
            this.pb_ajuda.TabIndex = 8;
            this.pb_ajuda.TabStop = false;
            this.pb_ajuda.Click += new System.EventHandler(this.pb_novaSenha_Click);
            // 
            // pb_visualizarAcesso
            // 
            this.pb_visualizarAcesso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pb_visualizarAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_visualizarAcesso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_visualizarAcesso.Location = new System.Drawing.Point(178, 0);
            this.pb_visualizarAcesso.Name = "pb_visualizarAcesso";
            this.pb_visualizarAcesso.Size = new System.Drawing.Size(89, 34);
            this.pb_visualizarAcesso.TabIndex = 8;
            this.pb_visualizarAcesso.TabStop = false;
            this.pb_visualizarAcesso.Click += new System.EventHandler(this.pb_novaSenha_Click);
            // 
            // panel_exibe
            // 
            this.panel_exibe.Controls.Add(this.panel_exibe_senha);
            this.panel_exibe.Controls.Add(this.txt_pesquisa);
            this.panel_exibe.Controls.Add(this.panel_nav);
            this.panel_exibe.Controls.Add(this.lbl_bloqueio);
            this.panel_exibe.Controls.Add(this.lb_nomeSenha);
            this.panel_exibe.Enabled = false;
            this.panel_exibe.Location = new System.Drawing.Point(27, 16);
            this.panel_exibe.Name = "panel_exibe";
            this.panel_exibe.Size = new System.Drawing.Size(410, 471);
            this.panel_exibe.TabIndex = 10;
            // 
            // FrmExibeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 495);
            this.Controls.Add(this.panel_bloqueia_tela);
            this.Controls.Add(this.panel_exibe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmExibeSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExibeSenha";
            this.Load += new System.EventHandler(this.FrmExibeSenha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExibeSenha_KeyDown);
            this.panel_exibe_senha.ResumeLayout(false);
            this.panel_exibe_senha.PerformLayout();
            this.panel_bloqueia_tela.ResumeLayout(false);
            this.panel_bloqueia_tela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_novaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ajuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visualizarAcesso)).EndInit();
            this.panel_exibe.ResumeLayout(false);
            this.panel_exibe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Panel panel_exibe_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ultimaVisualizacaoSenha;
        private System.Windows.Forms.TextBox txt_dataCadastroSenha;
        private System.Windows.Forms.TextBox txt_descricaoSenha;
        private System.Windows.Forms.TextBox txt_chaveSenha;
        private System.Windows.Forms.TextBox txt_nomeSenha;
        private System.Windows.Forms.TextBox txt_idSenha;
        private System.Windows.Forms.Panel panel_bloqueia_tela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_nomeSenha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_bloqueio;
        private System.Windows.Forms.PictureBox pb_novaSenha;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pb_ajuda;
        private System.Windows.Forms.PictureBox pb_visualizarAcesso;
        private System.Windows.Forms.Panel panel_exibe;
    }
}

