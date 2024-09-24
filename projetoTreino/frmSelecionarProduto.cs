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
