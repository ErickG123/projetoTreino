using FirebirdSql.Data.FirebirdClient;
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
    public partial class frmClientes : Form
    {
        private string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        private FbConnection conn;

        private string[] heads = { "Cod.", "Nome", "CPF", "Endereço" };
        private int[] widths = { 50, 200, 200, 200 };

        public frmClientes()
        {
            InitializeComponent();
            carregarDados();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btNovo, "Novo");
            tt.SetToolTip(btEditar, "Editar");
            tt.SetToolTip(btSalvar, "Salvar");
            tt.SetToolTip(btExportarCsv, "Exportar CSV");
        }

        public void carregarDados()
        {
            conn = new FbConnection(strConnection);
            
            string sql = @"SELECT c.id, c.nome, c.cpf,  c.endereco FROM clientes c";
            FbCommand cmd = new FbCommand(sql, conn);

            FbDataAdapter  dataAdapter = new FbDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            conn.Open();

            dataAdapter.Fill(dataSet, "clientes");

            grdClientes.DataSource = dataSet;
            grdClientes.DataMember = "clientes";
            
            conn.Close();

            Funcoes.limparTexto(plClientes);
            Funcoes.formatarGrid(grdClientes, heads, widths);
        }
    }
}
