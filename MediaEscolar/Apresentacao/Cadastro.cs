using MediaEscolar.Modelo;
using System;
using System.Drawing;
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
            controle.Cadastrar(txtMatricula.Text, txtSenha.Text, txtConfirmarSenha.Text,isProfessor);
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

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point lastLocation;

        private void Cadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void Cadastro_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }
    }
}
