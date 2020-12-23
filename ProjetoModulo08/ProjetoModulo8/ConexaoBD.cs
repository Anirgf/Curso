using MySql.Data.MySqlClient;
using System.Configuration;

namespace ProjetoModulo8
{
    public class ConexaoBD
    {
        private static readonly ConexaoBD instanciaMySQL = new ConexaoBD();

        public static ConexaoBD getInstancia()
        {
            return instanciaMySQL;
        }

        public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
