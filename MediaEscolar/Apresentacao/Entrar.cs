using MediaEscolar.Modelo;
using MediaEscolar.SQL;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point lastLocation;

        private void Entrar_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Entrar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            Conexao con = new Conexao();
            controle.EntrarNaConta(txbMatricula.Text, txbSenha.Text);
            int tipoUsuario = controle.TipoUsuario(txbMatricula.Text);

            if (!int.TryParse(txbMatricula.Text, out int matricula))
            {
                MessageBox.Show("Digite uma matrícula válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand cmd = new SqlCommand();
            string query = "SELECT nome,matricula, turma FROM logins WHERE matricula = @matricula";
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.CommandText = query;
            cmd.Connection = con.Conectar();
            con.Conectar();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                controle.nomeUsuario = reader["nome"].ToString();
                controle.matriculaUsuario = reader["matricula"].ToString();
                controle.turmaUsuario = reader["turma"].ToString();
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
                    else if (tipoUsuario == 2)
                    {
                        Secretaria.Secretaria secretaria = new Secretaria.Secretaria();
                        secretaria.Show();
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
    }
}