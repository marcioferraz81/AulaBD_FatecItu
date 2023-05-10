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
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                txtnome.ReadOnly = false;
            }
            else
            {
                txtnome.BackColor = Color.Red;
                txtnome.ForeColor = Color.White;
                txtnome.Text = "Não encontrado!";
                btnExcluir.Enabled = false;

            }
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente excluir o registro?";
            string caption = "Exclusão de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Categoria cat = new Categoria();
                MessageBox.Show(cat.excluir(txtId.Text));

                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

            limpar();

        }

        private void limpar()
        {
            txtId.Clear();
            txtnome.Clear();
            txtId.Focus();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtnome.ReadOnly = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente editar o registro?";
            string caption = "Edição de registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Categoria cat = new Categoria();
                cat.Id = Int32.Parse(txtId.Text);
                cat.Nome = txtnome.Text;
                MessageBox.Show(Categoria.editar(cat));

                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
