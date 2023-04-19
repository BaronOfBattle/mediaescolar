using MediaEscolar.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaEscolar.Apresentacao
{
    public partial class Aluno : Form
    {
        private readonly Controle controle;

        public Aluno(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            lblNomeAluno.Text = controle.nomeUsuario;
            lblMatricula.Text = controle.matriculaUsuario;
            lblTurma.Text = controle.turmaUsuario;
        }


        private void lblNomeAluno_Click(object sender, EventArgs e)
        {

        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            string matriculaUsuario = controle.matriculaUsuario;
            controle.PreencherMediasAluno(matriculaUsuario, lblMedia1, lblMedia2, lblMedia3, lblMedia4);

            double nota1, nota2, nota3, nota4;
            if (!double.TryParse(lblMedia1.Text, out nota1) || !double.TryParse(lblMedia2.Text, out nota2) ||
                !double.TryParse(lblMedia3.Text, out nota3) || !double.TryParse(lblMedia4.Text, out nota4))
            {
                lblAprovado.Visible = false;
            }
            else
            {
                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                if (media >= 6)
                {
                    lblAprovado.Text = "APROVADO";
                    lblAprovado.Visible = true;
                }
                else
                {
                    lblReprovado.Visible = true;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTurma_Click(object sender, EventArgs e)
        {

        }

        private Point lastLocation;
        private void Aluno_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void Aluno_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }
    }
}
