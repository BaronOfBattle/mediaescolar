using MediaEscolar.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediaEscolar.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public String nomeUsuario = "";
        public String matriculaUsuario = "";
        public String turmaUsuario = "";

        public bool EntrarNaConta(String matricula, String senha)
        {
            Comandos comando = new Comandos();

            tem = comando.VerificarLogin(matricula, senha);
            if (!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return tem;
        }

        public string CadastrarAluno(string nome, bool isProfessor, string turmaUsuario)
        {
            Comandos comando = new Comandos();
            this.mensagem = comando.CadastrarAluno(nome, isProfessor, turmaUsuario);
            if (comando.tem)
            {
                return mensagem;
            }
            this.tem = true;
            return mensagem;
        }

        public String Cadastrar(String matricula, String senha, String confirmarSenha, bool isProfessor)
        {
            Comandos comando = new Comandos();
            this.mensagem = comando.Cadastrar(matricula, senha, confirmarSenha, isProfessor);
            if (comando.tem)
            {
                return mensagem;
            }
            this.tem = true;
            return mensagem;
        }
        public int TipoUsuario(string matricula)
        {
            int tipo = -1;
            Conexao conexao = new Conexao();
            SqlConnection con = conexao.Conectar();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT tipo FROM logins WHERE matricula = @matricula";
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                tipo = Convert.ToInt32(dr["tipo"]);
            }

            dr.Close();
            conexao.Desconectar();

            return tipo;
        }

        public void PreencherComboBoxAlunos(ComboBox cbxAlunos, ComboBox cbxTurmas)
        {
            if (cbxTurmas.SelectedItem == null)
            {
                return;
            }
            Conexao conexao = new Conexao();
            SqlConnection con = conexao.Conectar();
            SqlCommand cmd = new SqlCommand();
            string turmaSelecionada = cbxTurmas.SelectedItem.ToString();
            string query = "SELECT nome FROM logins WHERE tipo = 0 AND turma = @turma";
            cmd.Parameters.AddWithValue("@turma", turmaSelecionada);
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbxAlunos.Items.Add(reader["nome"].ToString());
            }

            reader.Close();
            conexao.Desconectar();
        }


        public void PreencherComboBoxTurmas(ComboBox cbxTurmas)
        {
            Conexao conexao = new Conexao();
            SqlConnection con = conexao.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT turma FROM logins WHERE tipo = 0";

            HashSet<string> turmas = new HashSet<string>();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string turma = reader["turma"].ToString();
                if (!turmas.Contains(turma))
                {
                    cbxTurmas.Items.Add(turma);
                    turmas.Add(turma);
                }
            }

            reader.Close();
            conexao.Desconectar();
        }

        public string GetMatriculaAluno(string nomeAluno)
        {
            string matricula = "";
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT matricula FROM logins WHERE nome = @nome AND tipo = 0", conexao.Conectar());
            cmd.Parameters.AddWithValue("@nome", nomeAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                matricula = dr["matricula"].ToString();
            }
            dr.Close();
            conexao.Desconectar();
            return matricula;
        }

        public void GetMediaMatricula(string matriculaAluno, out string Media1, out string Media2, out string Media3, out string Media4)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT media_bim1, media_bim2, media_bim3, media_bim4 FROM medias WHERE matricula = @matricula", conexao.Conectar());
            cmd.Parameters.AddWithValue("@matricula", matriculaAluno);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Media1 = dr.IsDBNull(0) ? "X" : dr["media_bim1"].ToString();
                Media2 = dr.IsDBNull(1) ? "X" : dr["media_bim2"].ToString();
                Media3 = dr.IsDBNull(2) ? "X" : dr["media_bim3"].ToString();
                Media4 = dr.IsDBNull(3) ? "X" : dr["media_bim4"].ToString();
            }
            else
            {
                Media1 = "X";
                Media2 = "X";
                Media3 = "X";
                Media4 = "X";
            }

            dr.Close();
            conexao.Desconectar();
        }

        public void AtualizarMedia(string matriculaAluno, decimal media1, decimal media2, decimal media3, decimal media4)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("UPDATE medias SET media_bim1 = @media1, media_bim2 = @media2, media_bim3 = @media3, media_bim4 = @media4 WHERE matricula = @matriculaAluno", conexao.Conectar());
            cmd.Parameters.AddWithValue("@media1", media1);
            cmd.Parameters.AddWithValue("@media2", media2);
            cmd.Parameters.AddWithValue("@media3", media3);
            cmd.Parameters.AddWithValue("@media4", media4);
            cmd.Parameters.AddWithValue("@matriculaAluno", matriculaAluno);
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ResetarMedia(string matriculaAluno, string media)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand($"UPDATE medias SET {media} = NULL WHERE matricula = @matriculaAluno", conexao.Conectar());
            cmd.Parameters.AddWithValue("@matriculaAluno", matriculaAluno);
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void PreencherMediasAluno(string matriculaUsuario, Label lblMedia1, Label lblMedia2, Label lblMedia3, Label lblMedia4)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand("SELECT media_bim1, media_bim2, media_bim3, media_bim4 FROM medias WHERE matricula = @matricula", conexao.Conectar());
            cmd.Parameters.AddWithValue("@matricula", matriculaUsuario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblMedia1.Text = dr.IsDBNull(0) ? "X" : dr["media_bim1"].ToString();
                lblMedia2.Text = dr.IsDBNull(1) ? "X" : dr["media_bim2"].ToString();
                lblMedia3.Text = dr.IsDBNull(2) ? "X" : dr["media_bim3"].ToString();
                lblMedia4.Text = dr.IsDBNull(3) ? "X" : dr["media_bim4"].ToString();
            }
            else
            {
                lblMedia1.Text = "X";
                lblMedia2.Text = "X";
                lblMedia3.Text = "X";
                lblMedia4.Text = "X";
            }

            dr.Close();
            conexao.Desconectar();
        }
    }
}