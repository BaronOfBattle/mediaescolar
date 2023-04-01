using MediaEscolar.Modelo;
using MediaEscolar.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaEscolar.Apresentacao
{
    public partial class Professor : Form
    {
        private Controle controle;

        public Professor()
        {
            InitializeComponent();
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            controle = new Controle();
            controle.PreencherComboBox(cbxAlunos);
            cbxAlunos.SelectedIndex = 0;
        }


        private void cbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeAluno = cbxAlunos.SelectedItem.ToString();
            string matriculaAluno = controle.GetMatriculaAluno(nomeAluno);

            controle.GetMediaMatricula(matriculaAluno, out string media1, out string media2, out string media3, out string media4);

            lblMedia1.Text = media1;
            lblMedia2.Text = media2;
            lblMedia3.Text = media3;
            lblMedia4.Text = media4;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
