using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTreino
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se o Form já está aberto ou não
            var tem = Application.OpenForms.OfType<frmUsuarios>();
            if (tem.Any())
            {
                // Se estiver aberto, ele só joga na tela
                tem.First().WindowState = FormWindowState.Maximized;
                tem.First().BringToFront();
            }
            else
            {
                // Senão, ele abre o form
                frmUsuarios usu = new frmUsuarios();
                usu.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tem = Application.OpenForms.OfType<frmClientes>();
            if (tem.Any())
            {
                tem.First().WindowState = FormWindowState.Maximized;
                tem.First().BringToFront();
            }
            else
            {
                frmClientes cli = new frmClientes();
                cli.Show();
            }
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
