using MediaEscolar.Apresentacao;
using MediaEscolar.Apresentacao.Secretaria;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaEscolar
{
    public partial class Form1 : Form
    {
        private Entrar entrarInstance;
        private Cadastro cadastrarInstance;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void CadastrarClosed(object sender, FormClosedEventArgs e)
        {
            cadastrarInstance = null;
        }

        private void EntrarClosed(object sender, FormClosedEventArgs e)
        {
            entrarInstance = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cadastrarInstance == null)
            {
                cadastrarInstance = new Cadastro();
                cadastrarInstance.FormClosed += CadastrarClosed;
                cadastrarInstance.Show();
            }
            else
            {
                cadastrarInstance.BringToFront();
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (entrarInstance == null)
            {
                entrarInstance = new Entrar();
                entrarInstance.FormClosed += EntrarClosed;
                entrarInstance.Show();
            }
            else
            {
                entrarInstance.BringToFront();
            }
        }

        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }
    }
}
