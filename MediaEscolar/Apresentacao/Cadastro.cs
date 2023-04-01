using MediaEscolar.Modelo;
using System;
using System.Windows.Forms;

namespace MediaEscolar.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            bool isProfessor = radProfessor.Checked;
            String mensagem = controle.cadastrar(txtMatricula.Text, txtSenha.Text, txtConfirmarSenha.Text,isProfessor);
            if (controle.tem)
            {
                MessageBox.Show(controle.mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
        }

        private void radAluno_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radProfessor_CheckedChanged(object sender, EventArgs e)
        {
            {
             
            }
        }
    }
}
