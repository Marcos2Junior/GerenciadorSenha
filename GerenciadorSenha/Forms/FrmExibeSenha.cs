using GerenciadorSenha.Modelos;
using GerenciadorSenha.Servicos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GerenciadorSenha.Forms
{
    public partial class FrmExibeSenha : Form
    {
        private bool panelMovimentoRight = false;
        private bool panelMovimentoLeft = false;
        private int contadorPanel = 0;
        private int contadorBloqueio = 60;

        public string Key { get; set; }

        private List<Chave> Chaves;
        public FrmExibeSenha()
        {
            InitializeComponent();
        }

        private void MovimentoPanel()
        {
            //Movimenta panel para direita
            if (panel_bloqueia_tela.Size.Width >= 0 && panelMovimentoRight)
            {
                if (timer1.Interval != 100)
                    timer1.Interval = 100;

                contadorPanel = panel_bloqueia_tela.Size.Width;
                contadorPanel += 50;

                if (panel_bloqueia_tela.Size.Width >= 450)
                {
                    contadorPanel = 450;
                    panelMovimentoRight = false;
                }

                panel_bloqueia_tela.Size = new Size(contadorPanel, panel_bloqueia_tela.Size.Height);
            }

            //Movimenta panel para a esquerda
            if (panel_bloqueia_tela.Size.Width <= 450 && panelMovimentoLeft)
            {
                if (timer1.Interval != 100)
                    timer1.Interval = 100;

                contadorPanel = panel_bloqueia_tela.Size.Width;
                contadorPanel -= 50;

                if (contadorPanel <= 0)
                {
                    contadorPanel = 0;
                    panelMovimentoLeft = false;

                    txt_senha.Select();
                    txt_senha.Focus();
                    lbl_bloqueio.Text = "Processando o desbloqueio da tela ...";
                }
                panel_bloqueia_tela.Size = new Size(contadorPanel, panel_bloqueia_tela.Size.Height);
            }
        }

        private void BloqueioAutomatico()
        {
            //panel width zero significa que a tela esta desbloqueada
            if (panel_bloqueia_tela.Size.Width == 0)
            {
                if (timer1.Interval != 1000)
                    timer1.Interval = 1000;

                //sendo assim, enquanto o contador for >= zero vai alterando valor da label
                if (contadorBloqueio <= 0)
                {
                    //define novamente o valor para 60 segundos e altera propriedade para bloquear a tela no metodo MovimentoPanel
                    panelMovimentoRight = true;
                    contadorBloqueio = 60;
                    lbl_bloqueio.Text = "Processando o bloqueio da tela ...";
                    LimpaCampos();
                }
                else
                {
                    lbl_bloqueio.Text = "Bloqueio automático em " + contadorBloqueio + " segundos.";
                    contadorBloqueio--;
                }
            }
            else
            {
                panel_exibe.Enabled = true;
            }
        }

        private void LimpaCampos()
        {
            txt_chaveSenha.Clear();
            txt_dataCadastroSenha.Clear();
            txt_descricaoSenha.Clear();
            txt_idSenha.Clear();
            txt_nomeSenha.Clear();
            txt_pesquisa.Clear();
            txt_senha.Clear();
            txt_ultimaVisualizacaoSenha.Clear();
            lb_nomeSenha.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovimentoPanel();
            BloqueioAutomatico();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            string senha = "$9t9ptl6d2";
            if (txt_senha.Text == senha)
            {
                Key = txt_senha.Text;
                panelMovimentoLeft = true;
                CarregaDadosForm();
            }
        }

        private async void CarregaDadosForm()
        {
            //Desativa panel de bloqueio
            panel_bloqueia_tela.Enabled = true;
            //ativa panel exibe
            panel_exibe.Enabled = false;

            ChaveServices chaveServices = new ChaveServices(Key);
            await chaveServices.LerChavesAsync();
            Chaves = chaveServices.Chaves;

            Chaves.ForEach(x => lb_nomeSenha.Items.Add(x.Nome));

            txt_pesquisa.Select();
            txt_pesquisa.Focus();
        }

        private void FrmExibeSenha_Load(object sender, EventArgs e)
        {
            txt_senha.Select();
            timer1.Start();
        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            List<string> nomes = new List<string>();
            Chaves.ForEach(x =>
            {
                if (x.Nome.ToUpper().Contains(txt_pesquisa.Text.ToUpper()))
                {
                    nomes.Add(x.Nome);
                }
            });

            lb_nomeSenha.Items.Clear();

            if (nomes.Count > 0)
            {
                nomes.ForEach(x => lb_nomeSenha.Items.Add(x));
            }
        }

        private void pb_novaSenha_Click(object sender, EventArgs e)
        {
            FrmNovaSenha frm = new FrmNovaSenha();
            Hide();
            frm.Key = Key;
            _ = frm.ShowDialog();
            Show();
        }

        private void lb_nomeSenha_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _chave = Chaves.Where(x => x.Nome == lb_nomeSenha.SelectedItem.ToString()).FirstOrDefault();

            if (_chave != null)
            {
                txt_nomeSenha.Text = _chave.Nome;
                txt_chaveSenha.Text = _chave.Senha;
                txt_dataCadastroSenha.Text = _chave.DataCadastro.ToString();
                txt_descricaoSenha.Text = _chave.Observacao;
                txt_idSenha.Text = _chave.Id.ToString();
            }
        }

        private void FrmExibeSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                panelMovimentoRight = true;
                contadorBloqueio = 60;
                lbl_bloqueio.Text = "Processando o bloqueio da tela ...";
                LimpaCampos();
            }
        }
    }
}
