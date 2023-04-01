using MediaEscolar.Apresentacao;
using MediaEscolar.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaEscolar.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public String nomeUsuario = "";
        public String matriculaUsuario = "";

        public bool acessar(String matricula, String senha)
        {
            Comandos comando = new Comandos();

            tem = comando.verificarLogin(matricula, senha);
            if (!comando.mensagem.Equals(""))
            {
                this.mensagem = comando.mensagem;
            }
            return tem;
        }

        public String cadastrar(String matricula, String senha, String confirmarSenha, bool isProfessor)
        {
            Comandos comando = new Comandos();
            this.mensagem = comando.cadastrar(matricula, senha, confirmarSenha, isProfessor);
            if (comando.tem)
            {
                return mensagem;
            }
            this.tem = true;
            return mensagem;
        }
        public int getTipoUsuario(string matricula)
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

        public void PreencherComboBox(ComboBox cbxAunos)
        {
            Conexao conexao = new Conexao();
            SqlConnection con = conexao.Conectar();
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT nome FROM logins WHERE tipo = 0";
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbxAunos.Items.Add(reader["nome"].ToString());
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
            SqlCommand cmd = new SqlCommand("SELECT media_bim1, media_bim2, media_bim3, media_bim4 FROM tabela_medias WHERE matricula = @matricula", conexao.Conectar());
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

    }
}