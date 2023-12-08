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
    public partial class frmProdutos : Form
    {
        private string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        private FbConnection conn;

        private string[] heads = { "Cód.", "Descrição", "Custo Unitário", "Estoque", "Ativo?" };
        private int[] widths = { 50, 50, 50, 50, 50 };
        private TipoDeCadastro Modo = TipoDeCadastro.Novo;

        public frmProdutos()
        {
            InitializeComponent();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btNovo, "Novo Produto");
            tt.SetToolTip(btEditar, "Editar Produto");
            tt.SetToolTip(btSalvar, "Salvar");
            tt.SetToolTip(btExportarCsv, "Exportar CSV");
            tt.SetToolTip(btAtivarDesativar, "Ativar/Desativar Produto");
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Funcoes.limparTexto(plProdutos);
            txtCodigo.Text = Funcoes.ultimoCliente().ToString();
            Funcoes.habilitarCampos(plProdutos);
            txtDescricao.Focus();
            Modo = TipoDeCadastro.Novo;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count > 0)
            {
                Modo = TipoDeCadastro.Edicao;
                Funcoes.habilitarCampos(plProdutos);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(txtCodigo.Text);

            if (txtDescricao.Text.Length < 1)
            {
                MessageBox.Show("A Descrição do Produto é obrigatória", "Projeto Teste", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn = new FbConnection(strConnection);
            string sql = "";
            FbCommand cmd;

            switch (Modo)
            {
                case TipoDeCadastro.Edicao:
                    sql = @"UPDATE estoque SET
                           id = @id,
                           descricao = @descricao,
                           custounitario = @custounitario,
                           quantidadeestoque = @quantidadeestoque,
                           valorvendavista = @valorvendavista,
                           valorvendaprazo = @valorvendaprazo,
                           estoqueminimo = @estoqueminimo,
                           ativo = @ativo";
                    cmd = new FbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", idProduto);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@custounitario", txtCustoUnitario.Text);
                    cmd.Parameters.AddWithValue("@quantidadeestoque", txtQtdEstoque.Text);
                    cmd.Parameters.AddWithValue("@valorvendavista", txtValorVista.Text);
                    cmd.Parameters.AddWithValue("@valorvendaprazo", txtValorPrazo.Text);

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
                    MessageBox.Show("Produto atualizado com sucesso!");
                    conn.Close();
                    break;
                case TipoDeCadastro.Novo:
                    sql = @"INSERT INTO estoque (
                          id, descricao, custounitario, quantidadeestoque,
                          valorvendavista, valorvendaprazo
                          ) VALUES (
                          @id, @descricao,  @custounitario, @quantidadeestoque,
                          @valorvendavista, @valorvendaprazo)";
                    cmd = new FbCommand(sql, conn);

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
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    break;
            }
        }

        private void btExportarCsv_Click(object sender, EventArgs e)
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT * FROM estoque";

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            Funcoes.exportarCsv(dt, "Estoque.csv");
        }

        private void btAtivarDesativar_Click(object sender, EventArgs e)
        {
            if (grdProdutos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("O produto será (des)marcado como 'Inativo'. Deseja Continuar?", "Projeto Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    conn = new FbConnection(strConnection);

                    string simnao = (string)grdProdutos.SelectedRows[0].Cells["ativo"].Value;
                    int ativoInativo = simnao == "Sim" ? 1 : 0;

                    int idProduto = (int)grdProdutos.SelectedRows[0].Cells["id"].Value;

                    string sql = @"UPDATE estoque SET ativo = @ativo WHERE id = @id";
                    FbCommand cmd = new FbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idProduto);
                    cmd.Parameters.AddWithValue("@ativo", ativoInativo);

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
                }
            }
        }

        public void carregarDados()
        {
            conn = new FbConnection(strConnection);

            string sql = @"SELECT p.id, p.descricao, p.custounitario, p.quantidadeestoque, p.ativo FROM estoque";
            FbCommand cmd = new FbCommand(sql, conn);

            FbDataAdapter dataAdapter = new FbDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            conn.Open();

            dataAdapter.Fill(dataSet, "estoque");

            grdProdutos.DataSource = dataSet;
            grdProdutos.DataMember = "estoque";
            conn.Close();

            Funcoes.limparTexto(plProdutos);
            Funcoes.formatarGrid(grdProdutos, heads, widths);
        }

        private void frmProdutos_Shown(object sender, EventArgs e)
        {
            flpBotoes.Top = 0;
            flpBotoes.Left = 0;
            flpBotoes.Width = ClientSize.Width;
        }
    }
}
