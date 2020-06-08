using GerenciadorSenha.Modelos;
using GerenciadorSenha.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace GerenciadorSenha.Forms
{
    public partial class FrmNovaSenha : Form
    {
        #region Variaveis

        private List<Chave> Chaves;
        private bool NomeIgual;
        public string Key { get; set; }

        #endregion

        #region Construtor

        public FrmNovaSenha() => InitializeComponent();

        #endregion

        #region Eventos
        private void FrmNovaSenha_Load(object sender, EventArgs e) => CarregaDadosListBox();

        private void lbl_gravar_Click(object sender, EventArgs e) => Gravar();

        private void FrmNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gravar();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e) => ValidaNome();
        private void lbl_voltar_Click(object sender, EventArgs e) => Close();

        #endregion

        #region Metodos

        /// <summary>
        /// Feito a validação da entrada de dados da classe Chave com DataAnnotations;
        /// </summary>
        /// <returns>True caso esteja tudo OK</returns>
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
                    if (result.MemberNames.Count() > 0)
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
                    else
                    {
                        lbl_avisoDefault.Text = result.ErrorMessage;
                    }
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Verifica se nome digitado existe na lista de chaves existentes
        /// Caso o nome seja identico, é setado variavel NomeIgual = true;
        /// Ao mesmo tempo é alterado valores da listBox exibindo nomes que contem nome digitado
        /// 
        /// Metodo chamado no evento TextChanged do campo Nome
        /// </summary>
        private void ValidaNome()
        {
            List<string> nomes = new List<string>();
            NomeIgual = false;
            Chaves.ForEach(x =>
            {
                if (x.Nome.ToUpper().Contains(txt_nome.Text.ToUpper()))
                {
                    nomes.Add(x.Nome);

                    if (x.Nome.ToUpper() == txt_nome.Text.ToUpper())
                        NomeIgual = true;
                }
            });

            lbl_avisoNome.Text = NomeIgual ? "Ja existe registro com esse nome." : string.Empty;

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

        /// <summary>
        /// Grava os dados da nova senha
        /// </summary>
        private void Gravar()
        {
            if (ValidaDados() && !NomeIgual)
            {
                Chaves.Add(new Chave(Chaves.Count, txt_nome.Text, txt_chave.Text, txt_confChave.Text, txt_descricao.Text, DateTime.Now, null));

                ChaveServices chaveServices = new ChaveServices(Chaves, txt_senhaAcesso.Text);
                chaveServices.Gravar();

                MessageBox.Show("Senha gravada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        /// <summary>
        /// Limpa avisos de erro dos campos
        /// </summary>
        private void LimparAvisos()
        {
            lbl_avisoChave.Text = string.Empty;
            lbl_avisoConfChave.Text = string.Empty;
            lbl_avisoConfSenha.Text = string.Empty;
            lbl_avisoDescricao.Text = string.Empty;
            lbl_avisoNome.Text = string.Empty;
            lbl_avisoDefault.Text = string.Empty;
        }

        /// <summary>
        /// Limpa todos os campos
        /// </summary>
        private void LimparCampos()
        {
            txt_chave.Clear();
            txt_confChave.Clear();
            txt_descricao.Clear();
            txt_nome.Clear();
            txt_senhaAcesso.Clear();
        }

        /// <summary>
        /// Busca todas as senhas gravadas e preenche com apenas o nome a listBox
        /// </summary>
        private async void CarregaDadosListBox()
        {
            Chaves = await new ChaveServices(Key).LerChavesAsync();

            Chaves.ForEach(x => lb_nomeSenhas.Items.Add(x.Nome));
        }

        #endregion

      
    }
}
