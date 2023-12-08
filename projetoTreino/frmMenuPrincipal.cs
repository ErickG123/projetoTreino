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
            this.WindowState = FormWindowState.Maximized;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btClientes, "Cadastrar Clientes");
            tt.SetToolTip(btProdutos, "Cadastrar Produtos");
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
                usu.WindowState = FormWindowState.Maximized;
                usu.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFrmClientes();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            abrirFrmClientes();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            abrirFrmProdutos();
        }
        private void btVendas_Click(object sender, EventArgs e)
        {
            abrirFrmVendas();
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void abrirFrmClientes()
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
                cli.WindowState = FormWindowState.Maximized;
                cli.Show();
            }
        }

        public void abrirFrmProdutos()
        {
            var tem = Application.OpenForms.OfType<frmProdutos>();
            if (tem.Any())
            {
                tem.First().WindowState = FormWindowState.Maximized;
                tem.First().BringToFront();
            }
            else
            {
                frmProdutos pro = new frmProdutos();
                pro.WindowState = FormWindowState.Maximized;
                pro.Show();
            }
        }

        public void abrirFrmVendas()
        {
            var tem = Application.OpenForms.OfType<frmVendas>();
            if (tem.Any())
            {
                tem.First().WindowState = FormWindowState.Maximized;
                tem.First().BringToFront();
            }
            else
            {
                frmVendas ved = new frmVendas();
                ved.WindowState = FormWindowState.Maximized;
                ved.Show();
            }
        }

        private void frmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            flpBotoes.Top = 0;
            flpBotoes.Left = 0;
            flpBotoes.Width = ClientSize.Width;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    abrirFrmClientes();
                    break;
                case Keys.F2:
                    abrirFrmProdutos();
                    break;
                case Keys.F3:
                    abrirFrmVendas();
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
