using MediaEscolar.Modelo;
using System;
using System.Windows.Forms;

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
            controle.PreencherComboBoxTurmas(cbxTurmas);
            cbxTurmas.SelectedIndex = 0;
        }


        private void cbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matriculaAluno = controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString());

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
            decimal media1 = numMedia1.Value;
            decimal media2 = numMedia2.Value;
            decimal media3 = numMedia3.Value;
            decimal media4 = numMedia4.Value;

            controle.AtualizarMedia(controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString()), media1, media2, media3, media4);
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

        private void numMedia3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            controle.ResetarMedia(controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString()), "media_bim1");
            cbxAlunos_SelectedIndexChanged(sender, e);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            controle.ResetarMedia(controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString()), "media_bim2");
            cbxAlunos_SelectedIndexChanged(sender, e);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            controle.ResetarMedia(controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString()), "media_bim3");
            cbxAlunos_SelectedIndexChanged(sender, e);
        }

        private void btnX4_Click(object sender, EventArgs e)
        {
            controle.ResetarMedia(controle.GetMatriculaAluno(cbxAlunos.SelectedItem.ToString()), "media_bim4");
            cbxAlunos_SelectedIndexChanged(sender, e);
        }

        private void cbxTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAlunos.Items.Clear();
            controle.PreencherComboBoxAlunos(cbxAlunos, cbxTurmas);
            cbxAlunos.SelectedIndex = 0;
        }
    }
}
