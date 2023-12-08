namespace projetoTreino
{
    partial class frmProdutos
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
            plFiltros = new Panel();
            ckbValorEntre = new CheckBox();
            label10 = new Label();
            nmPrecoMaximo = new NumericUpDown();
            nmPrecoMinimo = new NumericUpDown();
            btFiltrar = new Button();
            label8 = new Label();
            txtFiltro = new TextBox();
            label1 = new Label();
            plProdutos = new Panel();
            txtValorVista = new TextBox();
            txtEstoqueMinimo = new TextBox();
            txtValorPrazo = new TextBox();
            txtQtdEstoque = new TextBox();
            txtCustoUnitario = new TextBox();
            txtDescricao = new TextBox();
            txtCodigo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbLCodigo = new Label();
            grdProdutos = new DataGridView();
            flpBotoes = new FlowLayoutPanel();
            btNovo = new Button();
            btEditar = new Button();
            btSalvar = new Button();
            btExportarCsv = new Button();
            btAtivarDesativar = new Button();
            plFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrecoMaximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmPrecoMinimo).BeginInit();
            plProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProdutos).BeginInit();
            flpBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // plFiltros
            // 
            plFiltros.BackColor = SystemColors.InactiveCaption;
            plFiltros.Controls.Add(ckbValorEntre);
            plFiltros.Controls.Add(label10);
            plFiltros.Controls.Add(nmPrecoMaximo);
            plFiltros.Controls.Add(nmPrecoMinimo);
            plFiltros.Controls.Add(btFiltrar);
            plFiltros.Controls.Add(label8);
            plFiltros.Controls.Add(txtFiltro);
            plFiltros.Controls.Add(label1);
            plFiltros.Location = new Point(12, 77);
            plFiltros.Name = "plFiltros";
            plFiltros.Size = new Size(245, 166);
            plFiltros.TabIndex = 0;
            // 
            // ckbValorEntre
            // 
            ckbValorEntre.AutoSize = true;
            ckbValorEntre.Location = new Point(4, 78);
            ckbValorEntre.Name = "ckbValorEntre";
            ckbValorEntre.Size = new Size(82, 19);
            ckbValorEntre.TabIndex = 9;
            ckbValorEntre.Text = "Valor entre";
            ckbValorEntre.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 107);
            label10.Name = "label10";
            label10.Size = new Size(23, 15);
            label10.TabIndex = 8;
            label10.Text = "até";
            // 
            // nmPrecoMaximo
            // 
            nmPrecoMaximo.Location = new Point(144, 103);
            nmPrecoMaximo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nmPrecoMaximo.Name = "nmPrecoMaximo";
            nmPrecoMaximo.Size = new Size(98, 23);
            nmPrecoMaximo.TabIndex = 7;
            // 
            // nmPrecoMinimo
            // 
            nmPrecoMinimo.Location = new Point(4, 103);
            nmPrecoMinimo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nmPrecoMinimo.Name = "nmPrecoMinimo";
            nmPrecoMinimo.Size = new Size(94, 23);
            nmPrecoMinimo.TabIndex = 6;
            // 
            // btFiltrar
            // 
            btFiltrar.Location = new Point(4, 132);
            btFiltrar.Name = "btFiltrar";
            btFiltrar.Size = new Size(238, 23);
            btFiltrar.TabIndex = 5;
            btFiltrar.Text = "Filtrar";
            btFiltrar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 31);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 3;
            label8.Text = "Nome/Código";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(3, 49);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(239, 23);
            txtFiltro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtros";
            // 
            // plProdutos
            // 
            plProdutos.Controls.Add(txtValorVista);
            plProdutos.Controls.Add(txtEstoqueMinimo);
            plProdutos.Controls.Add(txtValorPrazo);
            plProdutos.Controls.Add(txtQtdEstoque);
            plProdutos.Controls.Add(txtCustoUnitario);
            plProdutos.Controls.Add(txtDescricao);
            plProdutos.Controls.Add(txtCodigo);
            plProdutos.Controls.Add(label7);
            plProdutos.Controls.Add(label6);
            plProdutos.Controls.Add(label5);
            plProdutos.Controls.Add(label4);
            plProdutos.Controls.Add(label3);
            plProdutos.Controls.Add(label2);
            plProdutos.Controls.Add(lbLCodigo);
            plProdutos.Location = new Point(263, 77);
            plProdutos.Name = "plProdutos";
            plProdutos.Size = new Size(525, 121);
            plProdutos.TabIndex = 1;
            // 
            // txtValorVista
            // 
            txtValorVista.Location = new Point(10, 85);
            txtValorVista.Name = "txtValorVista";
            txtValorVista.Size = new Size(100, 23);
            txtValorVista.TabIndex = 13;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(247, 85);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(100, 23);
            txtEstoqueMinimo.TabIndex = 12;
            // 
            // txtValorPrazo
            // 
            txtValorPrazo.Location = new Point(123, 85);
            txtValorPrazo.Name = "txtValorPrazo";
            txtValorPrazo.Size = new Size(111, 23);
            txtValorPrazo.TabIndex = 11;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Location = new Point(381, 28);
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(100, 23);
            txtQtdEstoque.TabIndex = 10;
            // 
            // txtCustoUnitario
            // 
            txtCustoUnitario.Location = new Point(247, 28);
            txtCustoUnitario.Name = "txtCustoUnitario";
            txtCustoUnitario.Size = new Size(117, 23);
            txtCustoUnitario.TabIndex = 9;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(69, 28);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(165, 23);
            txtDescricao.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(10, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(46, 23);
            txtCodigo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 66);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 6;
            label7.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 66);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor a Prazo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 66);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Valor a Vista";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 10);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade Estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 10);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Custo Unitário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 10);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // lbLCodigo
            // 
            lbLCodigo.AutoSize = true;
            lbLCodigo.Location = new Point(10, 10);
            lbLCodigo.Name = "lbLCodigo";
            lbLCodigo.Size = new Size(46, 15);
            lbLCodigo.TabIndex = 0;
            lbLCodigo.Text = "Código";
            // 
            // grdProdutos
            // 
            grdProdutos.AllowUserToAddRows = false;
            grdProdutos.AllowUserToDeleteRows = false;
            grdProdutos.AllowUserToResizeRows = false;
            grdProdutos.BackgroundColor = Color.WhiteSmoke;
            grdProdutos.BorderStyle = BorderStyle.None;
            grdProdutos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProdutos.Location = new Point(12, 288);
            grdProdutos.Name = "grdProdutos";
            grdProdutos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdProdutos.RowHeadersVisible = false;
            grdProdutos.Size = new Size(776, 150);
            grdProdutos.TabIndex = 5;
            grdProdutos.TabStop = false;
            // 
            // flpBotoes
            // 
            flpBotoes.BackColor = SystemColors.Highlight;
            flpBotoes.Controls.Add(btNovo);
            flpBotoes.Controls.Add(btEditar);
            flpBotoes.Controls.Add(btSalvar);
            flpBotoes.Controls.Add(btExportarCsv);
            flpBotoes.Controls.Add(btAtivarDesativar);
            flpBotoes.Location = new Point(12, 12);
            flpBotoes.Name = "flpBotoes";
            flpBotoes.Size = new Size(776, 59);
            flpBotoes.TabIndex = 6;
            // 
            // btNovo
            // 
            btNovo.BackColor = Color.Transparent;
            btNovo.FlatStyle = FlatStyle.Flat;
            btNovo.ForeColor = SystemColors.Highlight;
            btNovo.Image = Properties.Resources.novo_small1;
            btNovo.Location = new Point(3, 3);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(55, 52);
            btNovo.TabIndex = 0;
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Transparent;
            btEditar.FlatStyle = FlatStyle.Flat;
            btEditar.ForeColor = SystemColors.Highlight;
            btEditar.Image = Properties.Resources.editar;
            btEditar.Location = new Point(64, 3);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(58, 52);
            btEditar.TabIndex = 1;
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.Transparent;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.ForeColor = SystemColors.Highlight;
            btSalvar.Image = Properties.Resources.salvar_small;
            btSalvar.Location = new Point(128, 3);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(58, 52);
            btSalvar.TabIndex = 2;
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExportarCsv
            // 
            btExportarCsv.BackColor = Color.Transparent;
            btExportarCsv.FlatStyle = FlatStyle.Flat;
            btExportarCsv.ForeColor = SystemColors.Highlight;
            btExportarCsv.Image = Properties.Resources.excel;
            btExportarCsv.Location = new Point(192, 3);
            btExportarCsv.Name = "btExportarCsv";
            btExportarCsv.Size = new Size(58, 52);
            btExportarCsv.TabIndex = 3;
            btExportarCsv.UseVisualStyleBackColor = false;
            btExportarCsv.Click += btExportarCsv_Click;
            // 
            // btAtivarDesativar
            // 
            btAtivarDesativar.BackColor = Color.Transparent;
            btAtivarDesativar.FlatStyle = FlatStyle.Flat;
            btAtivarDesativar.ForeColor = SystemColors.Highlight;
            btAtivarDesativar.Image = Properties.Resources.exclui_small1;
            btAtivarDesativar.Location = new Point(256, 3);
            btAtivarDesativar.Name = "btAtivarDesativar";
            btAtivarDesativar.Size = new Size(58, 52);
            btAtivarDesativar.TabIndex = 4;
            btAtivarDesativar.UseVisualStyleBackColor = false;
            btAtivarDesativar.Click += btAtivarDesativar_Click;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpBotoes);
            Controls.Add(grdProdutos);
            Controls.Add(plProdutos);
            Controls.Add(plFiltros);
            Name = "frmProdutos";
            Text = "Cadastro de Produtos";
            Shown += frmProdutos_Shown;
            plFiltros.ResumeLayout(false);
            plFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrecoMaximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmPrecoMinimo).EndInit();
            plProdutos.ResumeLayout(false);
            plProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdProdutos).EndInit();
            flpBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel plFiltros;
        private Panel plProdutos;
        private DataGridView grdProdutos;
        private FlowLayoutPanel flpBotoes;
        private TextBox txtValorVista;
        private TextBox txtEstoqueMinimo;
        private TextBox txtValorPrazo;
        private TextBox txtQtdEstoque;
        private TextBox txtCustoUnitario;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbLCodigo;
        private Label label8;
        private TextBox txtFiltro;
        private Label label1;
        private CheckBox ckbValorEntre;
        private Label label10;
        private NumericUpDown nmPrecoMaximo;
        private NumericUpDown nmPrecoMinimo;
        private Button btFiltrar;
        private Button btNovo;
        private Button btEditar;
        private Button btSalvar;
        private Button btExportarCsv;
        private Button btAtivarDesativar;
    }
}