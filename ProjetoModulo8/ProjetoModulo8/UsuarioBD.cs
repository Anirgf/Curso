using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoModulo8
{
    public class UsuarioBD
    {
        public string BuscarNome(int id)
        {
            using (MySqlConnection conexao = ConexaoBD.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MessageBox.Show("Conexão criada com sucesso!");
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "select nome from usuarios where id = @id;";
                    comando.Parameters.AddWithValue("id", id);


                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["nome"] != null)
                        {
                           return reader["nome"].ToString();
                        }
                    }
                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao MySQL: " + msqle.Message, "Erro");
                }
                finally
                {
                    conexao.Close();
                }
                return string.Empty;
            }   
        }

        public void InserirUsuario(string nome)
        {
            using (MySqlConnection conexao = ConexaoBD.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "insert into usuarios(nome) values (@nome);";
                    comando.Parameters.AddWithValue("nome", nome);
                    
                    int valorRetorno = comando.ExecuteNonQuery();
                    if (valorRetorno > 1)
                        MessageBox.Show("Erro ao inserir!");
                    else
                        MessageBox.Show("Inserido com sucesso!");

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao MySQL: " + msqle.Message, "Erro");
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
