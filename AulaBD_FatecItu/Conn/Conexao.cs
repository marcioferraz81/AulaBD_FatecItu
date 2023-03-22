﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using MySql.Data.MySqlClient;

namespace AulaBD_FatecItu
{
    class Conexao
    {
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection("Server=localhost;Database=bdaula;Uid=root;Pwd=;");
            try
            {
                conn.Open();
                MessageBox.Show("Conectado");
            }
            catch (MySqlException e)
            {
                conn = null;
                MessageBox.Show(e.Message);
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
