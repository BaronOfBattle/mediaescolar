using MediaEscolar.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
