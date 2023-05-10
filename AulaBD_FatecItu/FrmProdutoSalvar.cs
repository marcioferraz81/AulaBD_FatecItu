using AulaBD_FatecItu.Class;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaBD_FatecItu
{
    public partial class FrmProdutoSalvar : Form
    {
        public FrmProdutoSalvar()
        {
            InitializeComponent();

            MySqlDataReader res = Categoria.carregar();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    cmbCategoria.Items.Add(res["id"].ToString() + " | " + res["nome"].ToString());
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;

            string[] categoriaCarregar = cmbCategoria.SelectedItem.ToString().Split('|');
            p.Id_categoria = Int32.Parse(categoriaCarregar[0].Trim());

            MessageBox.Show(Produto.salvar(p));

            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtNome.Focus();
        }
    }
}
