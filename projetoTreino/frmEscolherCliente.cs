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
            frmClientesSimples frm = new();
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
