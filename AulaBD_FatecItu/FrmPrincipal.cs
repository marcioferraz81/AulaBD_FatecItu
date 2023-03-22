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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void itemCategoriaCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCategoriaCadastrar>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCategoriaCadastrar>().First().Focus();
            }
            else
            {
                FrmCategoriaCadastrar frm = new FrmCategoriaCadastrar();
                frm.Show();
            }
        }
    }
}
