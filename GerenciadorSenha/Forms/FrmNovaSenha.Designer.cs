namespace GerenciadorSenha.Forms
{
    partial class FrmNovaSenha
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
            this.lb_nomeSenhas = new System.Windows.Forms.ListBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_avisoConfSenha = new System.Windows.Forms.Label();
            this.lbl_avisoDescricao = new System.Windows.Forms.Label();
            this.lbl_avisoConfChave = new System.Windows.Forms.Label();
            this.lbl_avisoChave = new System.Windows.Forms.Label();
            this.lbl_avisoNome = new System.Windows.Forms.Label();
            this.txt_confChave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_senhaAcesso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_gravar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nomeSenhas
            // 
            this.lb_nomeSenhas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_nomeSenhas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nomeSenhas.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nomeSenhas.FormattingEnabled = true;
            this.lb_nomeSenhas.ItemHeight = 21;
            this.lb_nomeSenhas.Location = new System.Drawing.Point(48, 73);
            this.lb_nomeSenhas.Name = "lb_nomeSenhas";
            this.lb_nomeSenhas.Size = new System.Drawing.Size(357, 67);
            this.lb_nomeSenhas.TabIndex = 7;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descricao.Location = new System.Drawing.Point(21, 153);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.PlaceholderText = "Detalhes sobre a senha ex: Login, site...";
            this.txt_descricao.Size = new System.Drawing.Size(313, 16);
            this.txt_descricao.TabIndex = 3;
            this.txt_descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_chave
            // 
            this.txt_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_chave.Location = new System.Drawing.Point(21, 96);
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.PasswordChar = '*';
            this.txt_chave.PlaceholderText = "Senha";
            this.txt_chave.Size = new System.Drawing.Size(153, 16);
            this.txt_chave.TabIndex = 1;
            this.txt_chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Location = new System.Drawing.Point(21, 39);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "Nome para identificar sua senha";
            this.txt_nome.Size = new System.Drawing.Size(313, 16);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(191, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ultima visualização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(191, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_avisoConfSenha);
            this.panel1.Controls.Add(this.lbl_avisoDescricao);
            this.panel1.Controls.Add(this.lbl_avisoConfChave);
            this.panel1.Controls.Add(this.lbl_avisoChave);
            this.panel1.Controls.Add(this.lbl_avisoNome);
            this.panel1.Controls.Add(this.txt_confChave);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_senhaAcesso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_gravar);
            this.panel1.Controls.Add(this.txt_descricao);
            this.panel1.Controls.Add(this.txt_chave);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(48, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 274);
            this.panel1.TabIndex = 5;
            // 
            // lbl_avisoConfSenha
            // 
            this.lbl_avisoConfSenha.AutoSize = true;
            this.lbl_avisoConfSenha.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoConfSenha.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoConfSenha.Location = new System.Drawing.Point(23, 227);
            this.lbl_avisoConfSenha.Name = "lbl_avisoConfSenha";
            this.lbl_avisoConfSenha.Size = new System.Drawing.Size(0, 15);
            this.lbl_avisoConfSenha.TabIndex = 6;
            // 
            // lbl_avisoDescricao
            // 
            this.lbl_avisoDescricao.AutoSize = true;
            this.lbl_avisoDescricao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoDescricao.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoDescricao.Location = new System.Drawing.Point(21, 171);
            this.lbl_avisoDescricao.Name = "lbl_avisoDescricao";
            this.lbl_avisoDescricao.Size = new System.Drawing.Size(0, 15);
            this.lbl_avisoDescricao.TabIndex = 6;
            // 
            // lbl_avisoConfChave
            // 
            this.lbl_avisoConfChave.AutoSize = true;
            this.lbl_avisoConfChave.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoConfChave.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoConfChave.Location = new System.Drawing.Point(180, 116);
            this.lbl_avisoConfChave.Name = "lbl_avisoConfChave";
            this.lbl_avisoConfChave.Size = new System.Drawing.Size(0, 15);
            this.lbl_avisoConfChave.TabIndex = 6;
            // 
            // lbl_avisoChave
            // 
            this.lbl_avisoChave.AutoSize = true;
            this.lbl_avisoChave.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoChave.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoChave.Location = new System.Drawing.Point(21, 116);
            this.lbl_avisoChave.Name = "lbl_avisoChave";
            this.lbl_avisoChave.Size = new System.Drawing.Size(0, 15);
            this.lbl_avisoChave.TabIndex = 6;
            // 
            // lbl_avisoNome
            // 
            this.lbl_avisoNome.AutoSize = true;
            this.lbl_avisoNome.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoNome.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoNome.Location = new System.Drawing.Point(23, 59);
            this.lbl_avisoNome.Name = "lbl_avisoNome";
            this.lbl_avisoNome.Size = new System.Drawing.Size(0, 15);
            this.lbl_avisoNome.TabIndex = 6;
            // 
            // txt_confChave
            // 
            this.txt_confChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confChave.Location = new System.Drawing.Point(180, 96);
            this.txt_confChave.Name = "txt_confChave";
            this.txt_confChave.PasswordChar = '*';
            this.txt_confChave.PlaceholderText = "Confirmar Senha";
            this.txt_confChave.Size = new System.Drawing.Size(154, 16);
            this.txt_confChave.TabIndex = 2;
            this.txt_confChave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(180, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Confirmar senha";
            // 
            // txt_senhaAcesso
            // 
            this.txt_senhaAcesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senhaAcesso.Location = new System.Drawing.Point(21, 207);
            this.txt_senhaAcesso.Name = "txt_senhaAcesso";
            this.txt_senhaAcesso.PasswordChar = '*';
            this.txt_senhaAcesso.PlaceholderText = "Insira sua chave de acesso ao sistema";
            this.txt_senhaAcesso.Size = new System.Drawing.Size(313, 16);
            this.txt_senhaAcesso.TabIndex = 4;
            this.txt_senhaAcesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(21, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Confirme sua senha de acesso";
            // 
            // lbl_gravar
            // 
            this.lbl_gravar.AutoSize = true;
            this.lbl_gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_gravar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gravar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_gravar.Location = new System.Drawing.Point(288, 241);
            this.lbl_gravar.Name = "lbl_gravar";
            this.lbl_gravar.Size = new System.Drawing.Size(48, 17);
            this.lbl_gravar.TabIndex = 5;
            this.lbl_gravar.Text = "Gravar";
            this.lbl_gravar.Click += new System.EventHandler(this.lbl_gravar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(163, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senhas cadastradas";
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_voltar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_voltar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_voltar.Location = new System.Drawing.Point(387, 458);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(43, 17);
            this.lbl_voltar.TabIndex = 6;
            this.lbl_voltar.Text = "Voltar";
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_voltar_Click);
            // 
            // FrmNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 495);
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_nomeSenhas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNovaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Senhas - Nova Senha";
            this.Load += new System.EventHandler(this.FrmNovaSenha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_nomeSenhas;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_confChave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_senhaAcesso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_gravar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_voltar;
        private System.Windows.Forms.Label lbl_avisoNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_avisoDescricao;
        private System.Windows.Forms.Label lbl_avisoConfChave;
        private System.Windows.Forms.Label lbl_avisoChave;
        private System.Windows.Forms.Label lbl_avisoConfSenha;
    }
}