using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorSenha.Forms
{
    public partial class FrmUsuarioNovo : Form
    {
        public FrmUsuarioNovo()
        {
            InitializeComponent();
        }

        private void lbl_confirmar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {

        }

        private void FrmUsuarioNovo_Load(object sender, EventArgs e)
        {

        }
    }
}
