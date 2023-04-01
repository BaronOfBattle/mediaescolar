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

            decimal.TryParse(media1, out decimal media1Decimal);
            decimal.TryParse(media2, out decimal media2Decimal);
            decimal.TryParse(media3, out decimal media3Decimal);
            decimal.TryParse(media4, out decimal media4Decimal);

            numMedia1.Value = media1Decimal;
            numMedia2.Value = media2Decimal;
            numMedia3.Value = media3Decimal;
            numMedia4.Value = media4Decimal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeAluno = cbxAlunos.SelectedItem.ToString();
            string matriculaAluno = controle.GetMatriculaAluno(nomeAluno);

            decimal media1 = (decimal)numMedia1.Value;
            decimal media2 = (decimal)numMedia2.Value;
            decimal media3 = (decimal)numMedia3.Value;
            decimal media4 = (decimal)numMedia4.Value;

            controle.AtualizarMedia(matriculaAluno, media1, media2, media3, media4);
            cbxAlunos_SelectedIndexChanged(sender, e);


        }

        private void txbMedia1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbMedia2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
