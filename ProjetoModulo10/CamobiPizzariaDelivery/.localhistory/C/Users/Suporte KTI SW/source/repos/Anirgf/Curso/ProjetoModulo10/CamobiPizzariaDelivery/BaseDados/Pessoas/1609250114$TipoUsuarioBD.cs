using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDados.Pessoas
{
    public class TipoUsuarioBD
    {
        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigo)
        {
            var tipoUsuario = new TipoUsuario();
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

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();
                        oUsuario.Codigo = Convert.ToInt32(reader["Codigo"].ToString());
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"].ToString()), string.Empty);
                        oUsuario.Nome = reader["Nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listaUsuarios.Add(oUsuario);


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
            return listaUsuarios;
        }
    }
}
