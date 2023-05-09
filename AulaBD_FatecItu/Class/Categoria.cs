﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using MySql.Data.MySqlClient;

namespace AulaBD_FatecItu.Class
{
    internal class Categoria
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public static string salvar(Categoria c)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO categoria VALUES (null, @nome)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM categoria";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de categorias \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Nome: " + res["nome"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

        public static Boolean pesquisar(Categoria c)
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM categoria WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", c.Id);
            MySqlDataReader res = cmd.ExecuteReader();
            Boolean verificar = false;
            if (res.HasRows)
            {
                if (res.Read())
                {
                    c.Id = Int32.Parse(res["id"].ToString());
                    c.Nome = res["nome"].ToString();
                    verificar = true;
                }
            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM categoria WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                return "excluído";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string editar(Categoria c)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE categoria SET nome = @nome WHERE id = @id";
                //com mais atributos -> UPDATE categoria SET nome = @nome, ramal = @ramal WHERE id = @id
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }
    }
}
