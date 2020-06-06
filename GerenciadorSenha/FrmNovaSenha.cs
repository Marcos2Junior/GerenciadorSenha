using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorSenha
{
    public partial class FrmNovaSenha : Form
    {
        public List<Chave> Chaves { get; set; }

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
            Chaves.Add(new Chave(Chaves.Count, txt_nome.Text, txt_chave.Text, txt_descricao.Text, DateTime.Now, null));

            ChaveServices asd = new ChaveServices(Chaves);
            asd.Gravar();
        }

        private async void CarregaDadosListBox()
        {
            Chaves = await new ChaveServices().LerChavesAsync();

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
            FrmExibeSenha frm = new FrmExibeSenha();
            frm.ShowDialog();

            this.Close();
        }
    }
}
