﻿using System;
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
    public partial class frmEscolherCliente : Form
    {
        public frmEscolherCliente()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            frmClientesSimples frm = new frmClientesSimples();
            frm.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
