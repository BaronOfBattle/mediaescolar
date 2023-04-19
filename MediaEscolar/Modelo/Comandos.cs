using MediaEscolar.SQL;
using System;
using System.Data.SqlClient;

namespace MediaEscolar.Modelo
{
    class Comandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerificarLogin(String matricula, String senha)
        {
            cmd.CommandText = "select * from logins where matricula = @matricula and senha = @senha";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@matricula", matricula);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }

        public string CadastrarAluno(string nome, bool isProfessor, string turmaUsuario)
        {
            int tipoUsuario = isProfessor ? 1 : 0;

            if (string.IsNullOrEmpty(nome))
            {
                return "Por favor, insira o nome.";
            }

            if (!isProfessor && string.IsNullOrEmpty(turmaUsuario))
            {
                return "Por favor, insira a turma.";
            }

            string query = "INSERT INTO logins (nome, tipo, turma) VALUES (@nome, @tipoUsuario, @turma); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, con.Conectar()))
            {

                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                command.Parameters.AddWithValue("@turma", turmaUsuario);

                int matricula = Convert.ToInt32(command.ExecuteScalar());
                if (matricula > 0)
                {
                    con.Desconectar();
                    return $"Usuário cadastrado com sucesso. A matrícula foi gerada automaticamente: {matricula}";
                }
                else
                {
                    con.Desconectar();
                    return "Erro ao cadastrar usuário.";
                }
            }
        }


        public string Cadastrar(String matricula, String senha, String confirmarSenha, bool isProfessor)
        {
            tem = false;
            int tipoUsuario = isProfessor ? 1 : 0;

            if (string.IsNullOrEmpty(matricula))
            {
                return "Por favor, informe a sua matrícula.";
            }

            if (string.IsNullOrEmpty(senha))
            {
                return "Por favor, informe a sua senha.";
            }

            if (string.IsNullOrEmpty(confirmarSenha))
            {
                return "Por favor, confirme a sua senha.";
            }

            string query = "SELECT COUNT(*) FROM logins WHERE matricula = @matricula AND tipo = @tipoUsuario";
            using (SqlCommand command = new SqlCommand(query, con.Conectar()))
            {
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                int count = (int)command.ExecuteScalar();

                if (count == 0)
                {
                    con.Desconectar();
                    this.mensagem = "Matrícula não encontrada. O aluno deve entrar em contato com a escola.";
                    return mensagem;
                }

                query = "SELECT senha FROM logins WHERE matricula = @matricula AND senha IS NOT NULL";
                using (SqlCommand selectCommand = new SqlCommand(query, con.Conectar()))
                {
                    selectCommand.Parameters.AddWithValue("@matricula", matricula);
                    selectCommand.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                    var result = selectCommand.ExecuteScalar();

                    if (result != null)
                    {
                        string jáCadastrado = result.ToString();
                        con.Desconectar();
                        this.mensagem = "Você já está cadastrado.";
                        return mensagem;
                    }
                }


                if (senha == confirmarSenha)
                {
                    query = "UPDATE logins SET senha = @senha WHERE matricula = @matricula AND tipo = @tipoUsuario";
                    using (SqlCommand updateCommand = new SqlCommand(query, con.Conectar()))
                    {
                        updateCommand.Parameters.AddWithValue("@matricula", matricula);
                        updateCommand.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                        updateCommand.Parameters.AddWithValue("@senha", senha);

                        try
                        {
                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                this.mensagem = "Cadastro realizado com sucesso!";
                                tem = true;
                            }
                            else
                            {
                                this.mensagem = "Erro ao realizar cadastro.";
                            }
                        }
                        catch (SqlException)
                        {
                            this.mensagem = "Erro com Banco de Dados";
                        }
                    }
                }
                else
                {
                    this.mensagem = "As senhas não coincidem.";
                }

                con.Desconectar();
                return mensagem;
            }
        }
    }
}