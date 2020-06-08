namespace GerenciadorSenha.Forms
{
    partial class FrmUsuarioNovo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_avisoDefault = new System.Windows.Forms.Label();
            this.lbl_avisoDataNascimento = new System.Windows.Forms.Label();
            this.lbl_avisoDicaSenha = new System.Windows.Forms.Label();
            this.lbl_avisoConfSenha = new System.Windows.Forms.Label();
            this.lbl_avisoSenha = new System.Windows.Forms.Label();
            this.lbl_avisoNome = new System.Windows.Forms.Label();
            this.lbl_comoFunciona = new System.Windows.Forms.Label();
            this.rb_confirma = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dicaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_confSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(187, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gerenciador de senhas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(349, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuario novo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_avisoDefault);
            this.groupBox1.Controls.Add(this.lbl_avisoDataNascimento);
            this.groupBox1.Controls.Add(this.lbl_avisoDicaSenha);
            this.groupBox1.Controls.Add(this.lbl_avisoConfSenha);
            this.groupBox1.Controls.Add(this.lbl_avisoSenha);
            this.groupBox1.Controls.Add(this.lbl_avisoNome);
            this.groupBox1.Controls.Add(this.lbl_comoFunciona);
            this.groupBox1.Controls.Add(this.rb_confirma);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtp_dataNascimento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_dicaSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_confSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_confirmar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(70, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preencha corretamente os campos para criar sua conta";
            // 
            // lbl_avisoDefault
            // 
            this.lbl_avisoDefault.AutoSize = true;
            this.lbl_avisoDefault.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoDefault.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoDefault.Location = new System.Drawing.Point(268, 37);
            this.lbl_avisoDefault.Name = "lbl_avisoDefault";
            this.lbl_avisoDefault.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoDefault.TabIndex = 6;
            this.lbl_avisoDefault.Text = "Campo obrigatório.";
            // 
            // lbl_avisoDataNascimento
            // 
            this.lbl_avisoDataNascimento.AutoSize = true;
            this.lbl_avisoDataNascimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoDataNascimento.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoDataNascimento.Location = new System.Drawing.Point(93, 303);
            this.lbl_avisoDataNascimento.Name = "lbl_avisoDataNascimento";
            this.lbl_avisoDataNascimento.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoDataNascimento.TabIndex = 6;
            this.lbl_avisoDataNascimento.Text = "Campo obrigatório.";
            // 
            // lbl_avisoDicaSenha
            // 
            this.lbl_avisoDicaSenha.AutoSize = true;
            this.lbl_avisoDicaSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoDicaSenha.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoDicaSenha.Location = new System.Drawing.Point(93, 238);
            this.lbl_avisoDicaSenha.Name = "lbl_avisoDicaSenha";
            this.lbl_avisoDicaSenha.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoDicaSenha.TabIndex = 6;
            this.lbl_avisoDicaSenha.Text = "Campo obrigatório.";
            // 
            // lbl_avisoConfSenha
            // 
            this.lbl_avisoConfSenha.AutoSize = true;
            this.lbl_avisoConfSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoConfSenha.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoConfSenha.Location = new System.Drawing.Point(344, 173);
            this.lbl_avisoConfSenha.Name = "lbl_avisoConfSenha";
            this.lbl_avisoConfSenha.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoConfSenha.TabIndex = 6;
            this.lbl_avisoConfSenha.Text = "Campo obrigatório.";
            // 
            // lbl_avisoSenha
            // 
            this.lbl_avisoSenha.AutoSize = true;
            this.lbl_avisoSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoSenha.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoSenha.Location = new System.Drawing.Point(93, 173);
            this.lbl_avisoSenha.Name = "lbl_avisoSenha";
            this.lbl_avisoSenha.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoSenha.TabIndex = 6;
            this.lbl_avisoSenha.Text = "Campo obrigatório.";
            // 
            // lbl_avisoNome
            // 
            this.lbl_avisoNome.AutoSize = true;
            this.lbl_avisoNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avisoNome.ForeColor = System.Drawing.Color.Red;
            this.lbl_avisoNome.Location = new System.Drawing.Point(93, 105);
            this.lbl_avisoNome.Name = "lbl_avisoNome";
            this.lbl_avisoNome.Size = new System.Drawing.Size(111, 15);
            this.lbl_avisoNome.TabIndex = 6;
            this.lbl_avisoNome.Text = "Campo obrigatório.";
            // 
            // lbl_comoFunciona
            // 
            this.lbl_comoFunciona.AutoSize = true;
            this.lbl_comoFunciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_comoFunciona.Location = new System.Drawing.Point(211, 354);
            this.lbl_comoFunciona.Name = "lbl_comoFunciona";
            this.lbl_comoFunciona.Size = new System.Drawing.Size(262, 20);
            this.lbl_comoFunciona.TabIndex = 0;
            this.lbl_comoFunciona.Text = "Saiba como funciona antes de utilizar!";
            this.lbl_comoFunciona.Click += new System.EventHandler(this.lbl_confirmar_Click);
            // 
            // rb_confirma
            // 
            this.rb_confirma.AutoSize = true;
            this.rb_confirma.Location = new System.Drawing.Point(123, 395);
            this.rb_confirma.Name = "rb_confirma";
            this.rb_confirma.Size = new System.Drawing.Size(441, 24);
            this.rb_confirma.TabIndex = 5;
            this.rb_confirma.TabStop = true;
            this.rb_confirma.Text = "Concordo que li e compreendi o funcionamento do programa.";
            this.rb_confirma.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(30, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 4;
            // 
            // dtp_dataNascimento
            // 
            this.dtp_dataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataNascimento.Location = new System.Drawing.Point(93, 273);
            this.dtp_dataNascimento.Name = "dtp_dataNascimento";
            this.dtp_dataNascimento.Size = new System.Drawing.Size(220, 27);
            this.dtp_dataNascimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dica de senha";
            // 
            // txt_dicaSenha
            // 
            this.txt_dicaSenha.Location = new System.Drawing.Point(93, 208);
            this.txt_dicaSenha.Name = "txt_dicaSenha";
            this.txt_dicaSenha.PlaceholderText = "Pense em algo que apenas você saiba!";
            this.txt_dicaSenha.Size = new System.Drawing.Size(471, 27);
            this.txt_dicaSenha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar senha";
            // 
            // txt_confSenha
            // 
            this.txt_confSenha.Location = new System.Drawing.Point(344, 143);
            this.txt_confSenha.Name = "txt_confSenha";
            this.txt_confSenha.PlaceholderText = "Confirme sua senha de acesso";
            this.txt_confSenha.Size = new System.Drawing.Size(220, 27);
            this.txt_confSenha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(93, 143);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PlaceholderText = "Sua senha de acesso";
            this.txt_senha.Size = new System.Drawing.Size(220, 27);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(93, 73);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "Nome completo";
            this.txt_nome.Size = new System.Drawing.Size(471, 27);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_confirmar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_confirmar.Location = new System.Drawing.Point(546, 431);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(97, 25);
            this.lbl_confirmar.TabIndex = 0;
            this.lbl_confirmar.Text = "Confirmar";
            this.lbl_confirmar.Click += new System.EventHandler(this.lbl_confirmar_Click);
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_voltar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_voltar.Location = new System.Drawing.Point(732, 627);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(62, 25);
            this.lbl_voltar.TabIndex = 0;
            this.lbl_voltar.Text = "Voltar";
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_confirmar_Click);
            // 
            // FrmUsuarioNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.lbl_voltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUsuarioNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de senhas - Usuario novo";
            this.Load += new System.EventHandler(this.FrmUsuarioNovo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.DateTimePicker dtp_dataNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dicaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_confSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_comoFunciona;
        private System.Windows.Forms.RadioButton rb_confirma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_avisoDefault;
        private System.Windows.Forms.Label lbl_avisoDataNascimento;
        private System.Windows.Forms.Label lbl_avisoDicaSenha;
        private System.Windows.Forms.Label lbl_avisoConfSenha;
        private System.Windows.Forms.Label lbl_avisoSenha;
        private System.Windows.Forms.Label lbl_avisoNome;
        private System.Windows.Forms.Label lbl_voltar;
    }
}