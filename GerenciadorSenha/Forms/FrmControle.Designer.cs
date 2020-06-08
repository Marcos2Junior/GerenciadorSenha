namespace GerenciadorSenha.Forms
{
    partial class FrmControle
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
            this.lbl_usuarioNovo = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.lbl_deletarConta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_comoFunciona = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_precisaAjuda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_usuarioNovo
            // 
            this.lbl_usuarioNovo.AutoSize = true;
            this.lbl_usuarioNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_usuarioNovo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarioNovo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_usuarioNovo.Location = new System.Drawing.Point(178, 386);
            this.lbl_usuarioNovo.Name = "lbl_usuarioNovo";
            this.lbl_usuarioNovo.Size = new System.Drawing.Size(133, 25);
            this.lbl_usuarioNovo.TabIndex = 0;
            this.lbl_usuarioNovo.Text = "Usuario novo?";
            this.lbl_usuarioNovo.Click += new System.EventHandler(this.lbl_usuarioNovo_Click);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(367, 45);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.PlaceholderText = "Nome do usuario";
            this.txt_pesquisar.Size = new System.Drawing.Size(257, 23);
            this.txt_pesquisar.TabIndex = 1;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pesquisar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_pesquisar.Location = new System.Drawing.Point(364, 24);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(98, 17);
            this.lbl_pesquisar.TabIndex = 0;
            this.lbl_pesquisar.Text = "Pesquisar perfil";
            // 
            // lbl_deletarConta
            // 
            this.lbl_deletarConta.AutoSize = true;
            this.lbl_deletarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deletarConta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_deletarConta.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_deletarConta.Location = new System.Drawing.Point(334, 386);
            this.lbl_deletarConta.Name = "lbl_deletarConta";
            this.lbl_deletarConta.Size = new System.Drawing.Size(125, 25);
            this.lbl_deletarConta.TabIndex = 0;
            this.lbl_deletarConta.Text = "Deletar conta";
            this.lbl_deletarConta.Click += new System.EventHandler(this.lbl_deletarConta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_comoFunciona);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_usuario);
            this.groupBox1.Controls.Add(this.lbl_pesquisar);
            this.groupBox1.Controls.Add(this.txt_pesquisar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(70, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(43, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 85);
            this.label9.TabIndex = 0;
            this.label9.Text = "Selecione seu perfil na listagem ao lado\r\npara visualizar ou cadastrar suas senha" +
    "s.\r\nCaso ainda não possua uma conta, crie \r\numa agora mesmo clicando no link\r\nlo" +
    "go abaixo.";
            // 
            // lbl_comoFunciona
            // 
            this.lbl_comoFunciona.AutoSize = true;
            this.lbl_comoFunciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_comoFunciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_comoFunciona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_comoFunciona.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_comoFunciona.Location = new System.Drawing.Point(83, 80);
            this.lbl_comoFunciona.Name = "lbl_comoFunciona";
            this.lbl_comoFunciona.Size = new System.Drawing.Size(158, 21);
            this.lbl_comoFunciona.TabIndex = 0;
            this.lbl_comoFunciona.Text = "Saiba como funciona.";
            this.lbl_comoFunciona.Click += new System.EventHandler(this.lbl_comoFunciona_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(330, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 185);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // lb_usuario
            // 
            this.lb_usuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_usuario.FormattingEnabled = true;
            this.lb_usuario.ItemHeight = 21;
            this.lb_usuario.Location = new System.Drawing.Point(367, 70);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(257, 130);
            this.lb_usuario.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(36, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Armazene suas senhas pessoais de\r\n modo seguro e de fácil acesso!\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(187, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gerenciador de senhas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(330, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Painel de controle";
            // 
            // lbl_precisaAjuda
            // 
            this.lbl_precisaAjuda.AutoSize = true;
            this.lbl_precisaAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_precisaAjuda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_precisaAjuda.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_precisaAjuda.Location = new System.Drawing.Point(482, 386);
            this.lbl_precisaAjuda.Name = "lbl_precisaAjuda";
            this.lbl_precisaAjuda.Size = new System.Drawing.Size(159, 25);
            this.lbl_precisaAjuda.TabIndex = 0;
            this.lbl_precisaAjuda.Text = "Precisa de ajuda?";
            this.lbl_precisaAjuda.Click += new System.EventHandler(this.lbl_precisaAjuda_Click);
            // 
            // FrmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_precisaAjuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_deletarConta);
            this.Controls.Add(this.lbl_usuarioNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de senhas - Painel de controle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuarioNovo;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.Label lbl_deletarConta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_precisaAjuda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_comoFunciona;
    }
}