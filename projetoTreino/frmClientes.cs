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
using static projetoTreino.Enums;

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
        private int[] widths = { 50, 200, 100, 200 };
        private TipoDeCadastro Modo = TipoDeCadastro.Novo;

        public frmClientes()
        {
            InitializeComponent();
            carregarDados();
            combos();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btNovo, "Novo");
            tt.SetToolTip(btEditar, "Editar");
            tt.SetToolTip(btSalvar, "Salvar");
            tt.SetToolTip(btExportarCsv, "Exportar CSV");
        }

        public void carregarDados()
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT c.id, c.nome, c.cpf, c.endereco FROM clientes c";
            FbCommand cmd = new FbCommand(sql, conn);

            FbDataAdapter dataAdapter = new FbDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            conn.Open();

            dataAdapter.Fill(dataSet, "clientes");

            grdClientes.DataSource = dataSet;
            grdClientes.DataMember = "clientes";

            conn.Close();

            Funcoes.limparTexto(plClientes);
            Funcoes.formatarGrid(grdClientes, heads, widths);
        }

        public void combos()
        {
            DataTable dtSexo = new DataTable();
            dtSexo.Columns.Add("ID", typeof(string));
            dtSexo.Columns.Add("Descr", typeof(string));
            dtSexo.Rows.Add(new object[] { "F", "F" });
            dtSexo.Rows.Add(new object[] { "M", "M" });
            cmbSexo.DataSource = dtSexo;
            cmbSexo.DisplayMember = "Descr";
            cmbSexo.ValueMember = "ID";

            DataTable dtPessoa = new DataTable();
            dtPessoa.Columns.Add("ID", typeof(string));
            dtPessoa.Columns.Add("Descr", typeof(string));
            dtPessoa.Rows.Add(new object[] { "F", "F" });
            dtPessoa.Rows.Add(new object[] { "J", "J" });
            cmbPessoa.DataSource = dtPessoa;
            cmbPessoa.DisplayMember = "ID";
            cmbPessoa.ValueMember = "Descr";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Funcoes.limparTexto(plClientes);
            txtCodigo.Text = Funcoes.ultimoCliente().ToString();
            mkdDCadastro.Text = DateTime.Now.ToShortDateString();
            Funcoes.habilitarCampos(plClientes);
            txtNome.Focus();
            Modo = TipoDeCadastro.Novo;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (grdClientes.SelectedRows.Count > 0)
            {
                Modo = TipoDeCadastro.Edicao;
                Funcoes.habilitarCampos(plClientes);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DateTime dCadastro = DateTime.Now;
            int idCliente = int.Parse(txtCodigo.Text);

            if (txtCodigo.Text.Length < 1) {
                MessageBox.Show("O Código do Cliente é obrigatório", "Projeto Treino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNome.Text.Length < 1)
            {
                MessageBox.Show("O Nome do Cliente é obrigatório", "Projeto Treino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn = new FbConnection(strConnection);
            string sql = "";
            FbCommand cmd;

            switch(Modo)
            {
                case TipoDeCadastro.Edicao:
                    sql = @"UPDATE clientes SET 
                          id = @id,
                          nome = @nome,
                          cpf = @cpf,
                          cnpj = @cnpj,
                          sexo = @sexo,
                          pessoa = @pessoa,
                          endereco = @endereco,
                          numero = @numero,
                          cidade = @cidade,
                          bairro = @bairro,
                          cep = @cep,
                          uf = @uf,
                          telefone = @telefone,
                          datacadastro = @data";
                    cmd = new FbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", idCliente);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", mkdCpf.Text);
                    cmd.Parameters.AddWithValue("@cnpj", mkdCnpj.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.SelectedValue);
                    cmd.Parameters.AddWithValue("@pessoa", cmbPessoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@cidade", cmbCidade.SelectedValue);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cep", mkdCep.Text);
                    cmd.Parameters.AddWithValue("@uf", txtUf.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@datacadastro", dCadastro);

                    conn.Open();

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problema na Atualização" + ex.Message);
                        conn.Close();
                        return;
                    }

                    carregarDados();
                    MessageBox.Show("Cliente atualizado com sucesso!");
                    conn.Close();
                    break;
                case TipoDeCadastro.Novo:
                    sql = @"INSERT INTO clientes (
                          id, nome, cpf, cnpj, sexo, pessoa,
                          endereco,  numero, cidade, bairro, cep,
                          uf, telefone, datacadastro)
                          VALUES (
                          @id, @nome, @cpf, @cnpj, @sexo, @pessoa,
                          @endereco, @numero, @cidade, @bairro,  @cep,
                          @uf, @telefone, @datacadastro)";
                    cmd = new FbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", idCliente);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", mkdCpf.Text);
                    cmd.Parameters.AddWithValue("@cnpj", mkdCnpj.Text);
                    cmd.Parameters.AddWithValue("@sexo", cmbSexo.SelectedValue);
                    cmd.Parameters.AddWithValue("@pessoa", cmbPessoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@cidade", cmbCidade.SelectedValue);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@cep", mkdCep.Text);
                    cmd.Parameters.AddWithValue("@uf", txtUf.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@datacadastro", dCadastro);

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
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    break;
            }
        }

        private void btExportarCsv_Click(object sender, EventArgs e)
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT * FROM clientes";
            FbCommand cmd = new FbCommand(sql, conn);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            Funcoes.exportarCsv(dt, "Clientes.csv");
        }
    }
}
