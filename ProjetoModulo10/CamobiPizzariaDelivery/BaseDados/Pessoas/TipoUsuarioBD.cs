using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;

namespace BaseDados.Pessoas
{
    public class TipoUsuarioBD
    {
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigo)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = @"SELECT
                                            U.codigo_tipo_usuario AS CodigoTipoUsuario,
                                            TU.descricao AS DescricaoTipoUsuario
                                            FROM usuario as U
                                            INNER JOIN tipo_usuario AS TU ON U.codigo_tipo_usuario = TU.codigo
                                            WHERE U.codigo = @codigo";
                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["CodigoTipoUsuario"].ToString());
                        tipoUsuario.Descricao = reader["DescricaoTipoUsuario"].ToString();
                    }
                }
                catch (MySqlException mysqle)
                {
                    throw new System.Exception(mysqle.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
            return tipoUsuario;
        }
    }
}
