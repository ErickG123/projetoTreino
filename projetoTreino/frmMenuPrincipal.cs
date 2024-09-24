using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace projetoTreino
{
    public partial class frmMenuPrincipal : Form
    {
        private HttpListener listener;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            ToolTip tt = new();
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
                frmUsuarios usu = new();
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
                frmClientes cli = new();
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
                frmProdutos pro = new();
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
                frmVendas ved = new();
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

        private async void StartServer()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:5000/receber-cnpj/");
            listener.Start();

            while (true)
            {
                HttpListenerContext context = await listener.GetContextAsync();
                HttpListenerRequest request = context.Request;

                if (request.HttpMethod == "POST")
                {
                    using (StreamReader reader = new(request.InputStream, request.ContentEncoding))
                    {
                        string requestBody = reader.ReadToEnd();
                        JObject json = JObject.Parse(requestBody);

                        string cnpj = json["cnpj"]?.ToString() ?? string.Empty;
                        string data = json["data"]?.ToString() ?? string.Empty;
                        string status = json["statusCliente"]?.ToString() ?? string.Empty;

                        AppendText($"CNPJ: {cnpj} | Data: {data} | Status: {status}");

                        HttpListenerResponse response = context.Response;
                        string responseString = "CNPJ processado com sucesso!";
                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
                        response.OutputStream.Close();
                    }
                }
            }
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendText), new object[] { text });
                return;
            }
            txtLog.AppendText(text);
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Task.Run(() => StartServer());
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listener != null && listener.IsListening)
            {
                listener.Stop();
                listener.Close();
            }

            Application.Exit();
        }
    }
}
