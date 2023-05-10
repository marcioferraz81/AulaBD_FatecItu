using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using MySql.Data.MySqlClient;
/*
 * CREATE TABLE produto (
    id int PRIMARY KEY AUTO_INCREMENT,
    nome varchar(50),
    id_categoria int,
    FOREIGN KEY(id_categoria) REFERENCES categoria (id)
    );
*/

namespace AulaBD_FatecItu.Class
{
    internal class Produto
    {
        private int id;
        private string nome;
        private int id_categoria;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }

        public static string salvar(Produto p)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO produto VALUES (null, @nome, @id_categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@id_categoria", p.Id_categoria);
                cmd.ExecuteNonQuery();
                return "produto salvo com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT p.id, p.nome as produto, c.nome as categoria FROM produto p INNER JOIN categoria c ON c.id = p.id_categoria";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de Produtos \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Produto: " + res["produto"].ToString();
                    lista += " - Categoria: " + res["categoria"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }
    }
}
