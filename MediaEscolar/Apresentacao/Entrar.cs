using MediaEscolar.Modelo;
using MediaEscolar.SQL;
using System;
using System.Data.SqlClient;
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

            if (!int.TryParse(txbMatricula.Text, out int matricula))
            {
                MessageBox.Show("Digite uma matrícula válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand cmd = new SqlCommand();
            string query = "SELECT nome,matricula FROM logins WHERE matricula = @matricula";
            cmd.Parameters.AddWithValue("@matricula", matricula);
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
                        Professor professor = new Professor();
                        professor.Show();
                        this.Close();
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

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}