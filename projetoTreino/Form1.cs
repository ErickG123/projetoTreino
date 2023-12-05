using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Drawing;

namespace projetoTreino
{
    public partial class Form1 : Form
    {
        private string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        private FbConnection conn;

        private string[] heads = { "Cod.", "Nome", "Email" };
        private int[] widths = { 40, 323, 324 };

        public Form1()
        {
            InitializeComponent();
            carregarDados();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btSalvar, "Salvar");

            // Ativando Filtro das Colunas do DataGrid
            foreach (DataGridViewColumn column in grdUsuarios.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        // Cadastar Usuário
        private void btSalvar_Click(object sender, EventArgs e)
        {
            conn = new FbConnection(strConnection);

            string sql = @"
                INSERT INTO usuarios (id,  nome, email, password) VALUES (@id, @nome, @email, @senha)
            ";
            FbCommand cmd = new FbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@senha", mkdSenha.Text);

            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema na Inserção!" + ex.Message);
                conn.Close();
                return;
            }

            carregarDados();
            conn.Close();
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        // Filtrar Dados
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            carregarDados();
        }

        // Carregar os Dados dos Usuários no Grid
        private void carregarDados()
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT u.id, u.nome, u.email FROM usuarios u";
            if (txtFiltro.Text.Length > 0)
            {
                sql += " WHERE nome LIKE @texto OR email LIKE @texto";
            }

            FbCommand cmd = new FbCommand(sql, conn);
            if (txtFiltro.Text.Length  > 0)
            {
                cmd.Parameters.AddWithValue("@texto", txtFiltro.Text);
            }

            FbDataAdapter dataAdapter = new FbDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            conn.Open();

            dataAdapter.Fill(dataSet, "usuarios");

            grdUsuarios.DataSource = dataSet;
            grdUsuarios.DataMember = "usuarios";

            conn.Close();

            Funcoes.limparTexto(plUsuarios);
            Funcoes.formatarGrid(grdUsuarios, heads, widths);
        }
    }
}
