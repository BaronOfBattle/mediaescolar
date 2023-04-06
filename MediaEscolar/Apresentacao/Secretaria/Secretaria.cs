using System;
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
    }
}
