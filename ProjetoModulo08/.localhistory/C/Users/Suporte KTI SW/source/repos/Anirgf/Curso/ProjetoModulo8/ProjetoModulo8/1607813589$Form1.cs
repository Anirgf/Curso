using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProjetoModulo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioBD usu = new UsuarioBD();
            MessageBox.Show(usu.BuscarNome(Convert.ToInt32(txtIdBusca.Text.Trim())));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioBD usu = new UsuarioBD();
            usu.InserirUsuario(txtNome.Text.Trim());
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();

                comando.CommandText = "update usuarios set nome = @nome where id = @id;";

                comando.Parameters.AddWithValue("nome", txtNome2.Text.Trim());
                comando.Parameters.AddWithValue("id", Convert.ToInt32(txtId.Text.Trim()));

                int valorRetorno = comando.ExecuteNonQuery();

                if (valorRetorno > 1)
                    MessageBox.Show("Erro ao Alterar!");
                else
                    MessageBox.Show("Alterar com sucesso!");

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();

                comando.CommandText = "delete from usuarios where id = @id;";

                comando.Parameters.AddWithValue("id", Convert.ToInt32(txtId2.Text.Trim()));

                int valorRetorno = comando.ExecuteNonQuery();

                if (valorRetorno < 1)
                    MessageBox.Show("Erro ao Excluir!");
                else
                    MessageBox.Show("Excluido com sucesso!");

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
