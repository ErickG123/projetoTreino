using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTreino
{
    public static class Funcoes
    {
        // Formatação do DataGridView com os Títulos e Larguras especificados
        public static void formatarGrid(DataGridView dgv, string[] heads, int[] widths)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = heads[i];
                dgv.Columns[i].Width = widths[i];

                if (dgv.Columns[i].ValueType == typeof(int) || dgv.Columns[i].ValueType == typeof(decimal))
                {
                    dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    if (dgv.Columns[i].ValueType == typeof(decimal))
                    {
                        dgv.Columns[i].DefaultCellStyle.Format = "N2";
                    }
                }
            }
        }

        // Retorna todos os Botões e Caixas de Texto do Formulário com base no Tipo (Control)
        public static IEnumerable<Control> AllSubControls(Control control)
        => Enumerable.Repeat(control, 1).Union(control.Controls.OfType<Control>()
        .SelectMany(AllSubControls));

        // Limpar todos os Campos de Texto
        public static void limparTexto(Panel panel)
        {
            AllSubControls(panel).OfType<TextBox>().ToList().ForEach(t =>
            {
                t.Text = "";
            });

            AllSubControls(panel).OfType<MaskedTextBox>().ToList().ForEach(t =>
            {
                t.Text = "";
            });
        }

        // Habilitar os Campos
        public static void habilitarCampos(Panel panel)
        {
            AllSubControls(panel).Where(c => !(c is Label) && !(c is Panel)).ToList().ForEach(c =>
            {
                c.Enabled = true;
            });
        }

        // Desabilitar os Campos
        public static void desabilitarCampos(Panel panel)
        {
            AllSubControls(panel).Where(c => !(c is Label) && !(c is Panel)).ToList().ForEach(c =>
            {
                c.Enabled = false;
            });
        }

        // Pegando o ID do último Cliente cadastrado
        public static int ultimoCliente()
        {
            string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
            
            FbConnection conn = new FbConnection(strConnection);

            string sql = @"SELECT COALESCE(MAX(id) + 1, 2) Cli FROM clientes";
            FbCommand cmd = new FbCommand(sql, conn);

            conn.Open();

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return id;
        }

        // Exportar dados para um CSV
        public static void exportarCsv(DataTable dt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SEP=,");
            var headers = dt.Columns.Cast<DataColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => ($"\"{column.Caption.Replace("\"", "")}\"")).ToArray()));

            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine(string.Join(",", row.ItemArray.Select(cell => $"\"{cell.ToString().Replace("\"", "")}\"").ToArray()));
            }

            System.IO.File.WriteAllText(fileName, sb.ToString());
            MessageBox.Show("Exportado com sucesso!", "Projeto Treino", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var p = new Process();
            p.StartInfo = new ProcessStartInfo($"{fileName}")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        public static DialogResult inputBox(string titulo, string descricao, ref string valor)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = titulo;
            label.Text = descricao;
            textBox.Text = valor;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 127);
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        public static DataTable retornarCidades()
        {
            string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
            FbConnection conn = new FbConnection(strConnection);

            string sql = @"SELECT * FROM cidades";

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt;
        }

        public static DataTable retornarProdutos()
        {
            string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
            FbConnection conn = new FbConnection(strConnection);

            string sql = @"SELECT * FROM produtos";

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt;
        }
    }
}
