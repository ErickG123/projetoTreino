namespace projetoTreino
{
    partial class frmSelecionarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdProdutos = new DataGridView();
            txtPesquisa = new TextBox();
            txtCustoUnitario = new TextBox();
            txtQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbQuantidade = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grdProdutos
            // 
            grdProdutos.AllowUserToAddRows = false;
            grdProdutos.AllowUserToDeleteRows = false;
            grdProdutos.AllowUserToResizeRows = false;
            grdProdutos.BackgroundColor = Color.WhiteSmoke;
            grdProdutos.BorderStyle = BorderStyle.None;
            grdProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdutos.Location = new Point(12, 12);
            grdProdutos.MultiSelect = false;
            grdProdutos.Name = "grdProdutos";
            grdProdutos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdProdutos.RowHeadersVisible = false;
            grdProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProdutos.Size = new Size(240, 150);
            grdProdutos.TabIndex = 2;
            grdProdutos.TabStop = false;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 361);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(268, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // txtCustoUnitario
            // 
            txtCustoUnitario.Location = new Point(529, 361);
            txtCustoUnitario.Name = "txtCustoUnitario";
            txtCustoUnitario.Size = new Size(123, 23);
            txtCustoUnitario.TabIndex = 4;
            txtCustoUnitario.Text = "1";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(665, 361);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(123, 23);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 343);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 343);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "R$ Unitário";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(665, 343);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 8;
            lbQuantidade.Text = "Quantidade";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 31);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 8);
            label3.Name = "label3";
            label3.Size = new Size(560, 15);
            label3.TabIndex = 0;
            label3.Text = "<Setas do teclado> Navegar <+/-> Aumentar/diminuir quantidade <Enter> Confirmar <Esc> Fechar";
            // 
            // selecionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(panel1);
            Controls.Add(lbQuantidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCustoUnitario);
            Controls.Add(txtPesquisa);
            Controls.Add(grdProdutos);
            Name = "selecionarProduto";
            Text = "Selecionar Produto";
            ((System.ComponentModel.ISupportInitialize)grdProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdProdutos;
        private TextBox txtPesquisa;
        private TextBox txtCustoUnitario;
        private TextBox txtQuantidade;
        private Label label1;
        private Label label2;
        private Label lbQuantidade;
        private Panel panel1;
        private Label label3;
    }
}