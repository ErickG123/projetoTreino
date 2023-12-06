namespace projetoTreino
{
    partial class frmClientes
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
            plClientes = new Panel();
            mkdCep = new MaskedTextBox();
            txtUf = new TextBox();
            cmbCidade = new ComboBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            txtTelefone = new TextBox();
            mkdCnpj = new MaskedTextBox();
            mkdCpf = new MaskedTextBox();
            cmbPessoa = new ComboBox();
            cmbSexo = new ComboBox();
            txtNome = new TextBox();
            mkdDCadastro = new MaskedTextBox();
            txtCodigo = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbCpf = new Label();
            lbNome = new Label();
            lbCod = new Label();
            grdClientes = new DataGridView();
            plFiltro = new Panel();
            txtCpfCnpj = new TextBox();
            txtNomeEndereco = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btNovo = new Button();
            btEditar = new Button();
            btSalvar = new Button();
            btExportarCsv = new Button();
            flpBotoes = new FlowLayoutPanel();
            plClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            plFiltro.SuspendLayout();
            flpBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // plClientes
            // 
            plClientes.Controls.Add(mkdCep);
            plClientes.Controls.Add(txtUf);
            plClientes.Controls.Add(cmbCidade);
            plClientes.Controls.Add(txtBairro);
            plClientes.Controls.Add(txtNumero);
            plClientes.Controls.Add(txtEndereco);
            plClientes.Controls.Add(txtTelefone);
            plClientes.Controls.Add(mkdCnpj);
            plClientes.Controls.Add(mkdCpf);
            plClientes.Controls.Add(cmbPessoa);
            plClientes.Controls.Add(cmbSexo);
            plClientes.Controls.Add(txtNome);
            plClientes.Controls.Add(mkdDCadastro);
            plClientes.Controls.Add(txtCodigo);
            plClientes.Controls.Add(label14);
            plClientes.Controls.Add(label13);
            plClientes.Controls.Add(label12);
            plClientes.Controls.Add(label11);
            plClientes.Controls.Add(label10);
            plClientes.Controls.Add(label9);
            plClientes.Controls.Add(label8);
            plClientes.Controls.Add(label7);
            plClientes.Controls.Add(label6);
            plClientes.Controls.Add(label5);
            plClientes.Controls.Add(label4);
            plClientes.Controls.Add(lbCpf);
            plClientes.Controls.Add(lbNome);
            plClientes.Controls.Add(lbCod);
            plClientes.Location = new Point(12, 68);
            plClientes.Name = "plClientes";
            plClientes.Size = new Size(876, 285);
            plClientes.TabIndex = 1;
            // 
            // mkdCep
            // 
            mkdCep.Location = new Point(639, 147);
            mkdCep.Mask = "00\\.000\\-000";
            mkdCep.Name = "mkdCep";
            mkdCep.Size = new Size(106, 23);
            mkdCep.TabIndex = 27;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(579, 147);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(42, 23);
            txtUf.TabIndex = 26;
            // 
            // cmbCidade
            // 
            cmbCidade.FormattingEnabled = true;
            cmbCidade.Location = new Point(445, 147);
            cmbCidade.Name = "cmbCidade";
            cmbCidade.Size = new Size(121, 23);
            cmbCidade.TabIndex = 25;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(283, 147);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(147, 23);
            txtBairro.TabIndex = 24;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(214, 147);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(51, 23);
            txtNumero.TabIndex = 23;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(14, 147);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(182, 23);
            txtEndereco.TabIndex = 22;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(415, 84);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(137, 23);
            txtTelefone.TabIndex = 21;
            // 
            // mkdCnpj
            // 
            mkdCnpj.Location = new Point(191, 84);
            mkdCnpj.Mask = "00\\.000\\.000\\/0000\\-00";
            mkdCnpj.Name = "mkdCnpj";
            mkdCnpj.Size = new Size(205, 23);
            mkdCnpj.TabIndex = 20;
            // 
            // mkdCpf
            // 
            mkdCpf.Location = new Point(14, 84);
            mkdCpf.Mask = "000\\.000\\.000\\-00";
            mkdCpf.Name = "mkdCpf";
            mkdCpf.Size = new Size(159, 23);
            mkdCpf.TabIndex = 19;
            // 
            // cmbPessoa
            // 
            cmbPessoa.FormattingEnabled = true;
            cmbPessoa.Location = new Point(624, 28);
            cmbPessoa.Name = "cmbPessoa";
            cmbPessoa.Size = new Size(121, 23);
            cmbPessoa.TabIndex = 18;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(491, 28);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(191, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 23);
            txtNome.TabIndex = 16;
            // 
            // mkdDCadastro
            // 
            mkdDCadastro.Location = new Point(75, 28);
            mkdDCadastro.Mask = "00/00/0000";
            mkdDCadastro.Name = "mkdDCadastro";
            mkdDCadastro.Size = new Size(98, 23);
            mkdDCadastro.TabIndex = 15;
            mkdDCadastro.ValidatingType = typeof(DateTime);
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(14, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(46, 23);
            txtCodigo.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(75, 10);
            label14.Name = "label14";
            label14.Size = new Size(98, 15);
            label14.TabIndex = 13;
            label14.Text = "Data do Cadastro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(415, 66);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 12;
            label13.Text = "Telefone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(579, 129);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 11;
            label12.Text = "UF";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(639, 129);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 10;
            label11.Text = "CEP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(283, 129);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 9;
            label10.Text = "Bairro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 129);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 8;
            label9.Text = "Cidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 129);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 7;
            label8.Text = "Número";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 129);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 10);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Pessoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 10);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 66);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(14, 66);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(28, 15);
            lbCpf.TabIndex = 2;
            lbCpf.Text = "CPF";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(191, 10);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // lbCod
            // 
            lbCod.AutoSize = true;
            lbCod.Location = new Point(14, 10);
            lbCod.Name = "lbCod";
            lbCod.Size = new Size(46, 15);
            lbCod.TabIndex = 0;
            lbCod.Text = "Código";
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
            grdClientes.GridColor = SystemColors.ControlDark;
            grdClientes.Location = new Point(12, 359);
            grdClientes.MultiSelect = false;
            grdClientes.Name = "grdClientes";
            grdClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdClientes.RowHeadersVisible = false;
            grdClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdClientes.Size = new Size(552, 198);
            grdClientes.TabIndex = 6;
            // 
            // plFiltro
            // 
            plFiltro.BackColor = SystemColors.ActiveCaptionText;
            plFiltro.Controls.Add(txtCpfCnpj);
            plFiltro.Controls.Add(txtNomeEndereco);
            plFiltro.Controls.Add(label3);
            plFiltro.Controls.Add(label2);
            plFiltro.Controls.Add(label1);
            plFiltro.Location = new Point(570, 359);
            plFiltro.Name = "plFiltro";
            plFiltro.Size = new Size(318, 151);
            plFiltro.TabIndex = 3;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(15, 110);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(273, 23);
            txtCpfCnpj.TabIndex = 4;
            // 
            // txtNomeEndereco
            // 
            txtNomeEndereco.Location = new Point(15, 56);
            txtNomeEndereco.Name = "txtNomeEndereco";
            txtNomeEndereco.Size = new Size(273, 23);
            txtNomeEndereco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF/CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome/Endereço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtros";
            // 
            // btNovo
            // 
            btNovo.FlatStyle = FlatStyle.Flat;
            btNovo.ForeColor = SystemColors.MenuHighlight;
            btNovo.Image = Properties.Resources.novo_small1;
            btNovo.Location = new Point(3, 3);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(75, 47);
            btNovo.TabIndex = 0;
            btNovo.UseVisualStyleBackColor = true;
            btNovo.Click += btNovo_Click;
            // 
            // btEditar
            // 
            btEditar.FlatStyle = FlatStyle.Flat;
            btEditar.ForeColor = SystemColors.MenuHighlight;
            btEditar.Image = Properties.Resources.editar;
            btEditar.Location = new Point(84, 3);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 47);
            btEditar.TabIndex = 1;
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btSalvar
            // 
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.ForeColor = SystemColors.MenuHighlight;
            btSalvar.Image = Properties.Resources.salvar_small;
            btSalvar.Location = new Point(165, 3);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 47);
            btSalvar.TabIndex = 2;
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btExportarCsv
            // 
            btExportarCsv.FlatStyle = FlatStyle.Flat;
            btExportarCsv.ForeColor = SystemColors.MenuHighlight;
            btExportarCsv.Image = Properties.Resources.excel;
            btExportarCsv.Location = new Point(246, 3);
            btExportarCsv.Name = "btExportarCsv";
            btExportarCsv.Size = new Size(75, 47);
            btExportarCsv.TabIndex = 3;
            btExportarCsv.UseVisualStyleBackColor = true;
            btExportarCsv.Click += btExportarCsv_Click;
            // 
            // flpBotoes
            // 
            flpBotoes.BackColor = SystemColors.Highlight;
            flpBotoes.Controls.Add(btNovo);
            flpBotoes.Controls.Add(btEditar);
            flpBotoes.Controls.Add(btSalvar);
            flpBotoes.Controls.Add(btExportarCsv);
            flpBotoes.Location = new Point(12, 12);
            flpBotoes.Name = "flpBotoes";
            flpBotoes.Size = new Size(876, 50);
            flpBotoes.TabIndex = 7;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 569);
            Controls.Add(flpBotoes);
            Controls.Add(plFiltro);
            Controls.Add(grdClientes);
            Controls.Add(plClientes);
            Name = "frmClientes";
            Text = "Cadastro de Clientes";
            plClientes.ResumeLayout(false);
            plClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            plFiltro.ResumeLayout(false);
            plFiltro.PerformLayout();
            flpBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel plClientes;
        private DataGridView grdClientes;
        private Panel plFiltro;
        private TextBox txtCpfCnpj;
        private TextBox txtNomeEndereco;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private MaskedTextBox mkdDCadastro;
        private TextBox txtCodigo;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lbCpf;
        private Label lbNome;
        private Label lbCod;
        private TextBox txtTelefone;
        private MaskedTextBox mkdCnpj;
        private MaskedTextBox mkdCpf;
        private ComboBox cmbPessoa;
        private ComboBox cmbSexo;
        private MaskedTextBox mkdCep;
        private TextBox txtUf;
        private ComboBox cmbCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private Button btNovo;
        private Button btEditar;
        private Button btSalvar;
        private Button btExportarCsv;
        private FlowLayoutPanel flpBotoes;
    }
}