using AulaBD_FatecItu.Class;
using System;
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
    public partial class FrmCategoriaCadastrar : Form
    {
        public FrmCategoriaCadastrar()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            Categoria.salvar(cat);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            Categoria.salvar(cat);
        }
    }
}
