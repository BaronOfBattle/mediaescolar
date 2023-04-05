using MediaEscolar.Modelo;
using System;
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
                // Alguma nota é inválida
                lblAprovado.Visible = false;
            }
            else
            {
                // Todas as notas são válidas, calcular a média
                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                if (media >= 6)
                {
                    lblAprovado.Text = "Aprovado";
                    lblAprovado.Visible = true;
                }
                else
                {
                    lblAprovado.Text = "Reprovado";
                    lblAprovado.Visible = true;
                }
            }
        }
    }
}
