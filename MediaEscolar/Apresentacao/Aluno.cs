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

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT media_bim1, media_bim2, media_bim3, media_bim4 FROM tabela_medias WHERE matricula = @matricula", conexao.Conectar());
            cmd.Parameters.AddWithValue("@matricula", matriculaUsuario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblMedia1.Text = dr["media_bim1"].ToString();
                lblMedia2.Text = dr["media_bim2"].ToString();
                lblMedia3.Text = dr["media_bim3"].ToString();
                lblMedia4.Text = dr["media_bim4"].ToString();
            }
            dr.Close();
            conexao.Desconectar();
        }
    }
}
