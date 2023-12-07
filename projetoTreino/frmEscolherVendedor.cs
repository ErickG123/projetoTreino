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
    public partial class frmEscolherVendedor : Form
    {
        public frmEscolherVendedor()
        {
            InitializeComponent();
        }

        private void frmEscolherVendedor_Shown(object sender, EventArgs e)
        {
            grdVendedores.Top = 0;
            grdVendedores.Left = 0;
            grdVendedores.Width = ClientSize.Width;
            grdVendedores.Height = btOk.Top - 5;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
