using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaEscolar.Apresentacao.Secretaria
{
    public partial class Secretaria : Form
    {
        public Secretaria()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
        }

        private void Secretaria_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point lastLocation;
        private void Secretaria_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Secretaria_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }
    }
}
