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
            Process.Start(fileName);
        }
    }
}
