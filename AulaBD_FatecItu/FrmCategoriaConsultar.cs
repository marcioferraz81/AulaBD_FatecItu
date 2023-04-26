using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaBD_FatecItu.Class;

namespace AulaBD_FatecItu
{
    public partial class FrmCategoriaConsultar : Form
    {
        public FrmCategoriaConsultar()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Id = Int32.Parse(txtId.Text);
            //txtnome.Text = Categoria.pesquisar(cat) ? cat.Nome : "Não encontrado!";

            if (Categoria.pesquisar(cat))
            {
                txtnome.BackColor = Color.White;
                txtnome.ForeColor = Color.Black;
                txtnome.Text = cat.Nome;
            }
            else
            {
                txtnome.BackColor = Color.Red;
                txtnome.ForeColor = Color.White;
                txtnome.Text = "Não encontrado!";
            }
            txtId.Focus();
        }
    }
}
