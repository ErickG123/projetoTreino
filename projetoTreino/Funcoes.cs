using System;
using System.Collections.Generic;
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
    }
}
