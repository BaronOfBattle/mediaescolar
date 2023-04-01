using MediaEscolar.Modelo;
using MediaEscolar.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaEscolar.Apresentacao
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            Conexao con = new Conexao();
            controle.acessar(txbMatricula.Text, txbSenha.Text);
            int tipoUsuario = controle.getTipoUsuario(txbMatricula.Text);
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT nome,matricula FROM logins WHERE matricula = @matricula";
            cmd.Parameters.AddWithValue("@matricula", txbMatricula.Text);
            cmd.CommandText = query;
            cmd.Connection = con.Conectar();
            con.Conectar();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                controle.nomeUsuario = reader["nome"].ToString();
                controle.matriculaUsuario = reader["matricula"].ToString();
            }
            reader.Close();

            con.Desconectar();

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tipoUsuario == 1)
                    {

                    }
                    else
                    {
                        Aluno aluno = new Aluno(controle);
                        aluno.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Conta não encontrada. Verifique sua matrícula e sua senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
