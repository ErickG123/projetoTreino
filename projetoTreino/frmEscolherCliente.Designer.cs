namespace projetoTreino
{
    partial class frmEscolherCliente
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
            grdClientes = new DataGridView();
            btSalvar = new Button();
            btCancelar = new Button();
            lbPesquisar = new Label();
            txtPesquisar = new TextBox();
            grdListaClientes = new DataGridView();
            lbNome = new Label();
            lbEndereco = new Label();
            lbCpf = new Label();
            lbCidade = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdListaClientes).BeginInit();
            SuspendLayout();
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            grdClientes.AllowUserToResizeRows = false;
            grdClientes.BackgroundColor = Color.WhiteSmoke;
            grdClientes.BorderStyle = BorderStyle.None;
            grdClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Location = new Point(12, 12);
            grdClientes.MultiSelect = false;
            grdClientes.Name = "grdClientes";
            grdClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdClientes.RowHeadersVisible = false;
            grdClientes.Size = new Size(280, 150);
            grdClientes.TabIndex = 8;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(526, 415);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 1;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(445, 415);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 2;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // lbPesquisar
            // 
            lbPesquisar.AutoSize = true;
            lbPesquisar.Location = new Point(12, 9);
            lbPesquisar.Name = "lbPesquisar";
            lbPesquisar.Size = new Size(57, 15);
            lbPesquisar.TabIndex = 9;
            lbPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 27);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(589, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // grdListaClientes
            // 
            grdListaClientes.AllowUserToAddRows = false;
            grdListaClientes.AllowUserToDeleteRows = false;
            grdListaClientes.AllowUserToResizeRows = false;
            grdListaClientes.BackgroundColor = Color.WhiteSmoke;
            grdListaClientes.BorderStyle = BorderStyle.None;
            grdListaClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListaClientes.GridColor = SystemColors.ControlDark;
            grdListaClientes.Location = new Point(12, 56);
            grdListaClientes.Name = "grdListaClientes";
            grdListaClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdListaClientes.RowHeadersVisible = false;
            grdListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdListaClientes.Size = new Size(614, 207);
            grdListaClientes.TabIndex = 98;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 266);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 99;
            lbNome.Text = "Nome";
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(12, 310);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(56, 15);
            lbEndereco.TabIndex = 100;
            lbEndereco.Text = "Endereço";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(321, 266);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 101;
            lbCpf.Text = "CPF";
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(321, 310);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(44, 15);
            lbCidade.TabIndex = 102;
            lbCidade.Text = "Cidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 103;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 328);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 23);
            textBox2.TabIndex = 104;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 23);
            textBox3.TabIndex = 105;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(321, 328);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 23);
            textBox4.TabIndex = 106;
            // 
            // btNovo
            // 
            btNovo.Location = new Point(12, 415);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(125, 23);
            btNovo.TabIndex = 107;
            btNovo.Text = "Novo Cadastro";
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // frmEscolherCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(btNovo);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbCidade);
            Controls.Add(lbCpf);
            Controls.Add(lbEndereco);
            Controls.Add(lbNome);
            Controls.Add(grdListaClientes);
            Controls.Add(txtPesquisar);
            Controls.Add(lbPesquisar);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(grdClientes);
            Name = "frmEscolherCliente";
            Text = "Escolher Cliente";
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdListaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdClientes;
        private Button btSalvar;
        private Button btCancelar;
        private Label lbPesquisar;
        private TextBox txtPesquisar;
        private DataGridView grdListaClientes;
        private Label lbNome;
        private Label lbEndereco;
        private Label lbCpf;
        private Label lbCidade;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btNovo;
    }
}