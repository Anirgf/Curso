﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

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
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MessageBox.Show("Conexão criada com sucesso!");
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();

                comando.CommandText = "select nome from usuarios where id;";
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["nome"] != null)
                    {
                        MessageBox.Show(reader["nome"].ToString());
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection conexao = new MySqlConnection(conn);

            try
            {
                conexao.Open();
                MessageBox.Show("Conexão criada com sucesso!");
                MySqlCommand comando = new MySqlCommand();
                comando = conexao.CreateCommand();

                comando.CommandText = "insert into usuarios(nome) values (@nome);";
                comando.Parameters.AddWithValue("nome", txtNome.Text.Trim());
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
