using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace Filminhos.NET
{
    // Simple user model
    public class Usuario
    {
        public int Id { get; init; }
        public string Nome { get; init; } = string.Empty;
        public bool IsAdmin { get; init; }
    }

    // Session holder for the currently logged user
    public static class Sessao
    {
        public static Usuario? UsuarioAtual { get; set; }
    }

    public class Classes
    {
        public class Sistema
        {
            // Keep existing behavior for compatibility
            public bool CadastrarUsuario(string nome, string senha)
            {
                Classes.AcessoBD bd = new Classes.AcessoBD();
                using MySqlConnection con = bd.getMySqlConnection();

                string sql = "INSERT INTO usuarios (nome, senha) VALUES (@nome, @senha)";
                using MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                cmd.ExecuteNonQuery();
                return true;
            }

            // Backward-compatible boolean check
            public bool Consultar(string nome, string senha)
            {
                var usuario = AutenticarUsuario(nome, senha);
                return usuario != null;
            }

            // New: returns a Usuario (and sets Sessao.UsuarioAtual) or null on failure
            public Usuario? AutenticarUsuario(string nome, string senha)
            {
                Env.Load();
                string adminUser = Env.GetString("ADMIN_USER") ?? string.Empty;
                string adminPass = Env.GetString("ADMIN_PASS") ?? string.Empty;

                Classes.AcessoBD bd = new Classes.AcessoBD();
                using MySqlConnection con = bd.getMySqlConnection();

                string sql = "SELECT codigo, nome, senha FROM usuarios WHERE nome = @nome AND senha = @senha";
                using MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                using MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int id = Convert.ToInt32(dr["codigo"]);
                    string foundName = dr["nome"].ToString() ?? string.Empty;

                    // Determine admin: either matches ENV admin credentials or some DB role (not present)
                    bool isAdmin = (string.Equals(foundName, adminUser, StringComparison.OrdinalIgnoreCase)
                                    && string.Equals(senha, adminPass, StringComparison.Ordinal));

                    var usuario = new Usuario { Id = id, Nome = foundName, IsAdmin = isAdmin };

                    dr.Close();
                    Sessao.UsuarioAtual = usuario;
                    return usuario;
                }

                // If not found, make sure session is cleared
                Sessao.UsuarioAtual = null;
                return null;
            }
        };

        public class AcessoBD
        {
            private string connectionString;
            private MySqlConnection connection;
            private Boolean flagConexao;// = false;

            public AcessoBD()
            {
                Env.Load();
                connectionString = Env.GetString("DB_CONNECTION_STRING");
                connection = new MySqlConnection(connectionString);
                OpenConexaoBD(connectionString);
            }

            public MySqlConnection getMySqlConnection()
            {
                return connection;
            }

            public void OpenConexaoBD(string CString)
            {
                //connection = new MySqlConnection(CString);
                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    //connection.Open();
                    flagConexao = true;
                    //MessageBox.Show("CONEXAO ESTABELECIDA COM SUCESSO");
                }
                catch (Exception ex)
                {
                    flagConexao = false;
                    MessageBox.Show("ERRO: CONEXAO NAO ESTABELECIDA - " + ex.Message);
                }
            }

            public void CloseConexaoBD()
            {
                if (flagConexao == true)
                {
                    connection.Close();
                    //MessageBox.Show("CONEXAO FECHADA COM SUCESSO");
                }
            }
        };
    }


    public class ConexaoBD : Filminhos.NET.Classes.AcessoBD
    {
        private string query;
        private MySqlConnection connection;
        public ConexaoBD()
        {
            query = "";
            connection = getMySqlConnection();
        }

        public void setQuery(string q)
        {
            query = q;
        }

        public DataTable GetAllItems()
        {
            //MySqlConnection connection = getMySqlConnection();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            // "SELECT titulo as Titulo, ano_lancamento as 'Ano de Lancamento', duracao as Duração, class_indicada as 'Classificação Indicada', bilheteria as Bilheteria, avaliacao as Avaliação FROM filme"
            //setQuery("SELECT * FROM filme");
            setQuery("SELECT codigo as codigo, titulo as Titulo, ano_lancamento as 'Ano de Lancamento'," + // ADICIONEI O ID DOS FILMES
                     " duracao as Duração, class_indicada as 'Classificação Indicada'," +
                     " bilheteria as Bilheteria, avaliacao as Avaliação, link_poster FROM filme");

            DataTable dt = new DataTable();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dt);
            }

            CloseConexaoBD();
            return dt;
        }

        public List<string> getGeneros()
        {
            List<string> generos = new List<string>();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            setQuery("SELECT * FROM genero");

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            generos.Add(reader["genero"].ToString() ?? "");
                        }
                        return generos;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERRO: Pesquisa Invalida " + ex.Message);
                return new List<string>();
            }
            finally
            {
                CloseConexaoBD();
            }
        }

        public DataTable pesquisar(string pesquisa, int genero)
        {
            DataTable dt = new DataTable();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            //MySqlConnection connection = getMySQLConnection();
            setQuery("SP_PESQUISAR_FILMES");

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                //Orientar Mysql a Chamar a procedure
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_termo_pesquisa", pesquisa);
                command.Parameters.AddWithValue("@p_id_genero", genero);
                try
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    CloseConexaoBD();
                    return dt;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    CloseConexaoBD();
                }
            }
        }

        // CREATE 
        public bool InserirFilme(string titulo, int ano, string duracao, string classificacao, string bilheteria, decimal avaliacao, int idGenero)
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            string sql = "INSERT INTO filme (titulo, ano_lancamento, duracao, class_indicada, bilheteria, avaliacao, id_gen) " +
                         "VALUES (@titulo, @ano, @duracao, @class, @bilheteria, @avaliacao, @idGenero)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@ano", ano);
                    cmd.Parameters.AddWithValue("@duracao", duracao);
                    cmd.Parameters.AddWithValue("@class", classificacao);
                    cmd.Parameters.AddWithValue("@bilheteria", bilheteria);
                    cmd.Parameters.AddWithValue("@avaliacao", avaliacao);
                    cmd.Parameters.AddWithValue("@idGenero", idGenero);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseConexaoBD();
            }
        }

        // UPDATE
        public bool AtualizarFilme(int codigo, string titulo, int ano, string duracao, string classificacao, string bilheteria, decimal avaliacao)
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            string sql = "UPDATE filme SET titulo=@titulo, ano_lancamento=@ano, duracao=@duracao, " +
                         "class_indicada=@class, bilheteria=@bilheteria, avaliacao=@avaliacao" +
                         " WHERE codigo=@codigo";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@ano", ano);
                    cmd.Parameters.AddWithValue("@duracao", duracao);
                    cmd.Parameters.AddWithValue("@class", classificacao);
                    cmd.Parameters.AddWithValue("@bilheteria", bilheteria);
                    cmd.Parameters.AddWithValue("@avaliacao", avaliacao);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConexaoBD();
            }
        }

        // DELETE
        public bool ExcluirFilme(int codigo)
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            string sql = "DELETE FROM filme WHERE codigo = @codigo";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConexaoBD();
            }
        }



        public DataTable GetGenerosParaCombo()
        {
            DataTable dt = new DataTable();
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            // Supondo que sua tabela genero tenha colunas: id, genero
            setQuery("SELECT codigo, genero FROM genero");

            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch { return null; }
            finally { CloseConexaoBD(); }
        }

        //fim da classe ConexaoBD
    }
}
