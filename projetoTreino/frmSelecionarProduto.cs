using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTreino
{
    public partial class frmSelecionarProduto : Form
    {
        public frmSelecionarProduto()
        {
            InitializeComponent();

            grdProdutos.Width = ClientSize.Width;
            grdProdutos.Height = ClientSize.Height;
            grdProdutos.Top = 0;
            grdProdutos.Left = 0;
            grdProdutos.DataSource = "";
        }
    }
}
