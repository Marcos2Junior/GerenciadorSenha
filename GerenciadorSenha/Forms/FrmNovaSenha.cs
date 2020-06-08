using GerenciadorSenha.Modelos;
using GerenciadorSenha.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GerenciadorSenha.Forms
{
    public partial class FrmNovaSenha : Form
    {
        private List<Chave> Chaves;
        public string Key { get; set; }

        public FrmNovaSenha()
        {
            InitializeComponent();
        }

        private void FrmNovaSenha_Load(object sender, EventArgs e)
        {
            CarregaDadosListBox();
        }

        private void lbl_gravar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Chaves.Add(new Chave(Chaves.Count, txt_nome.Text, txt_chave.Text, txt_confChave.Text, txt_descricao.Text, DateTime.Now, null));

                ChaveServices asd = new ChaveServices(Chaves, txt_senhaAcesso.Text);
                asd.Gravar();

                MessageBox.Show("Senha gravada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private bool ValidaDados()
        {
            LimparAvisos();

            if (txt_senhaAcesso.Text != Key)
            {
                lbl_avisoConfSenha.Text = "Senha de acesso inválida.";
                return false;
            }

            Chave chave = new Chave(Chaves.Count, txt_nome.Text, txt_chave.Text, txt_confChave.Text, txt_descricao.Text, DateTime.Now, null);

            ValidationContext context = new ValidationContext(chave, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(chave, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    foreach (var item in result.MemberNames)
                    {
                        switch (item)
                        {
                            case "Nome":
                                lbl_avisoNome.Text = result.ErrorMessage;
                                break;

                            case "Senha":
                                lbl_avisoChave.Text = result.ErrorMessage;
                                break;

                            case "ConfSenha":
                                lbl_avisoConfChave.Text = result.ErrorMessage;
                                break;

                            case "Observacao":
                                lbl_avisoDescricao.Text = result.ErrorMessage;
                                break;
                        }
                    }
                }

                return false;
            }

            return true;
        }

        private void LimparAvisos()
        {
            lbl_avisoChave.Text = string.Empty;
            lbl_avisoConfChave.Text = string.Empty;
            lbl_avisoConfSenha.Text = string.Empty;
            lbl_avisoDescricao.Text = string.Empty;
            lbl_avisoNome.Text = string.Empty;
        }

        private void LimparCampos()
        {
            txt_chave.Clear();
            txt_confChave.Clear();
            txt_descricao.Clear();
            txt_nome.Clear();
            txt_senhaAcesso.Clear();
        }

        private async void CarregaDadosListBox()
        {
            Chaves = await new ChaveServices(Key).LerChavesAsync();

            Chaves.ForEach(x => lb_nomeSenhas.Items.Add(x.Nome));
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            List<string> nomes = new List<string>();
            bool nomeIgual = false;
            Chaves.ForEach(x =>
            {
                if (x.Nome.ToUpper().Contains(txt_nome.Text.ToUpper()))
                {
                    nomes.Add(x.Nome);

                    if (x.Nome.ToUpper() == txt_nome.Text.ToUpper())
                        nomeIgual = true;
                }
            });

            lbl_avisoNome.Text = nomeIgual ? "Ja existe registro com esse nome." : string.Empty;

            lb_nomeSenhas.Items.Clear();

            if (nomes.Count > 0)
            {
                nomes.ForEach(x => lb_nomeSenhas.Items.Add(x));
            }
            else
            {
                lbl_avisoNome.Text = string.Empty;
            }
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
