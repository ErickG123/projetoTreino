using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Data.Common;
using System.Drawing;
using static projetoTreino.Enums;

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
        private TipoDeCadastro Modo = TipoDeCadastro.Novo;

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
            string sql = "";
            FbCommand cmd;

            // Validando se os Campos foram Preenchidos
            if (txtId.Text.Length < 1 || txtNome.Text.Length  < 1 || txtEmail.Text.Length < 1 || mkdSenha.Text.Length < 1)
            {
                MessageBox.Show("Está faltando Informações", "ProjetoTeste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Efetuando a Operação com Base no TipoDeCadastro
            switch (Modo)
            {
                case TipoDeCadastro.Edicao:
                    // Código para Atualizar um Usuário
                    sql = @"UPDATE usuarios 
                    SET nome = @nome, email = @email, password = @senha
                    WHERE id = @id";
                    cmd = new FbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", mkdSenha.Text);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                    conn.Open();

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problema na Inserção!" + ex.Message);
                        conn.Close();
                    }

                    carregarDados();
                    MessageBox.Show("Usuário atualizado com sucesso!");
                    conn.Close();
                    break;
                case TipoDeCadastro.Novo:
                    // Código para Criar um Novo Usuário
                    sql = @"INSERT INTO usuarios (id,  nome, email, password) 
                                 VALUES (@id, @nome, @email, @senha)";
                    cmd = new FbCommand(sql, conn);

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
                    break;
            }
        }

        // Filtrar Dados
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            carregarDados();
        }

        // Editar Dados
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (grdUsuarios.SelectedRows.Count > 0)
            {
                Modo = TipoDeCadastro.Edicao;
                Funcoes.habilitarCampos(plUsuarios);
                txtId.Enabled = false;
            }
        }
        
        // Mostrar dados nos campos
        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                grdUsuarios.CurrentRow.Selected = true;
                txtId.Text = grdUsuarios.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = grdUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtEmail.Text = grdUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
            }
            Funcoes.desabilitarCampos(plUsuarios);
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
            if (txtFiltro.Text.Length > 0)
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
