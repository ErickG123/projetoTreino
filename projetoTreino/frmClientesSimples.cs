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
    public partial class frmClientesSimples : Form
    {
        private string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        private FbConnection conn;

        public frmClientesSimples()
        {
            InitializeComponent();
            combos();

            txtCodigo.Text = Funcoes.ultimoCliente().ToString();
            txtCodigo.Enabled = false;
            txtDCadastro.Text = DateTime.Now.ToShortDateString();
            txtDCadastro.Enabled = false;
            txtNome.Focus();
        }

        public void combos()
        {
            DataTable dtSexo = new DataTable();
            dtSexo.Columns.Add("ID", typeof(string));
            dtSexo.Columns.Add("Descr", typeof(string));
            dtSexo.Rows.Add(new object[] { "F", "F" });
            dtSexo.Rows.Add(new object[] { "M", "M" });
            cmbSexoS.DataSource = dtSexo;
            cmbSexoS.DisplayMember = "Descr";
            cmbSexoS.ValueMember = "ID";

            DataTable dtPessoa = new DataTable();
            dtPessoa.Columns.Add("ID", typeof(string));
            dtPessoa.Columns.Add("Descr", typeof(string));
            dtPessoa.Rows.Add(new object[] { "F", "F" });
            dtPessoa.Rows.Add(new object[] { "J", "J" });
            cmbPessoa.DataSource = dtPessoa;
            cmbPessoa.DisplayMember = "ID";
            cmbPessoa.ValueMember = "Descr";

            DataTable dtCidade = new DataTable();
            dtCidade = retornarCidades();
            cmbCidade.DataSource = dtCidade;
            cmbCidade.DisplayMember = "id";
            cmbCidade.ValueMember = "nome";
        }

        public DataTable retornarCidades()
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT * FROM cidades";

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 1)
            {
                MessageBox.Show("O Nome do Cliente é obrigatório", "Projeto Test", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dCadastro = DateTime.Now;
            int idCliente = int.Parse(txtCodigo.Text);

            string sql = @"INSERT INTO clientes (
                          id, nome, cpf, cnpj, sexo, pessoa,
                          endereco,  numero, cidade, bairro, cep,
                          uf, telefone, datacadastro)
                          VALUES (
                          @id, @nome, @cpf, @cnpj, @sexo, @pessoa,
                          @endereco, @numero, @cidade, @bairro,  @cep,
                          @uf, @telefone, @datacadastro)";
            FbCommand cmd = new FbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", idCliente);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
            cmd.Parameters.AddWithValue("@sexo", cmbSexoS.SelectedValue);
            cmd.Parameters.AddWithValue("@pessoa", cmbPessoa.SelectedValue);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
            cmd.Parameters.AddWithValue("@cidade", cmbCidade.SelectedValue);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cep", txtCep.Text);
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

            conn.Close();
            MessageBox.Show("Cliente cadastrado com sucesso!", "Projeto Treino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
