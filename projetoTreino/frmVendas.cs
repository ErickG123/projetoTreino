using System.Text.RegularExpressions;

namespace projetoTreino
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Shown(object sender, EventArgs e)
        {
            frmEscolherVendedor frm = new();
            while (frm.ShowDialog() != DialogResult.OK)
            {
                frm = new frmEscolherVendedor();
                frm.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    frmEscolherCliente fec = new();
                    fec.ShowDialog();
                    break;
                case Keys.F2:
                    frmEscolherVendedor fev = new();
                    fev.ShowDialog();
                    break;
                case Keys.F4:
                    frmFecharVenda ffv = new();
                    ffv.ShowDialog();
                    break;
                case Keys.X:
                    string _tmp = "";
                    if (Funcoes.inputBox("Teste", "Digite algo:", ref _tmp) == DialogResult.OK)
                    {
                        decimal tmpQtdAtual;
                        if (decimal.TryParse(Regex.Replace(_tmp, "[^0-9,]", ""), out tmpQtdAtual))
                        {

                        }
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
