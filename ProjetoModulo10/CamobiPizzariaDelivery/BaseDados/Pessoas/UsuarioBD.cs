﻿using Entidades.Enumeradores;
using Entidades.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDados.Pessoas
{
    public class UsuarioBD
    {   
        public List<Usuario> ListaUsuarios()
        {
            var listaUsuarios = new List<Usuario>();
            using(MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    comando.CommandText = "SELECT * FROM usuario WHERE situacao = 1;";

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
                catch(MySqlException mysqle)
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
