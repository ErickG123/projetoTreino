namespace projetoTreino
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public void inv(Label lbl, string s)
        {
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new MethodInvoker(delegate ()
                {
                    lbl.Text = s;
                    lbl.Left = (Width - lbl.Width) / 2;
                }));
            }
            else
            {
                lbl.Text = s;
                lbl.Left = (Width - lbl.Width) / 2;
            }
        }

        public void hid()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    Close();
                }));
            }
            else
            {
                Close();
            }
            Application.Run(new frmLogin());
        }

        public void loads()
        {
            inv(lblSplash, "1/2 Carregando XPTO");
            Thread.Sleep(1000);

            inv(lblSplash, "2/2 Carregando Menu");
            Thread.Sleep(2000);

            hid();
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            Thread t = new(new ThreadStart(loads));
            t.Start();
        }
    }
}
