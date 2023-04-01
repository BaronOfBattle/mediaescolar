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
        }


        private void cbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeAluno = cbxAlunos.SelectedItem.ToString();
            string matriculaAluno = controle.GetMatriculaAluno(nomeAluno);

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT media_bim1, media_bim2, media_bim3, media_bim4 FROM tabela_medias WHERE matricula = @matricula", conexao.Conectar());
            cmd.Parameters.AddWithValue("@matricula", matriculaAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblMedia1.Text = dr.IsDBNull(0) ? "X" : dr["media_bim1"].ToString();
                lblMedia2.Text = dr.IsDBNull(1) ? "X" : dr["media_bim2"].ToString();
                lblMedia3.Text = dr.IsDBNull(2) ? "X" : dr["media_bim3"].ToString();
                lblMedia4.Text = dr.IsDBNull(3) ? "X" : dr["media_bim4"].ToString();
            }

            dr.Close();
            conexao.Desconectar();
        }
    }
}
