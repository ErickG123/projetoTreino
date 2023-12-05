namespace projetoTreino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btSalvar = new Button();
            lbNome = new Label();
            lbEmail = new Label();
            lbSenha = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            grdUsuarios = new DataGridView();
            plUsuarios = new Panel();
            txtId = new TextBox();
            lbId = new Label();
            mkdSenha = new MaskedTextBox();
            panel1 = new Panel();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            plUsuarios.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(7, 183);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(213, 23);
            btSalvar.TabIndex = 0;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(7, 48);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(7, 92);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(7, 136);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 3;
            lbSenha.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(7, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(7, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 5;
            // 
            // grdUsuarios
            // 
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Location = new Point(12, 233);
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.Size = new Size(730, 303);
            grdUsuarios.TabIndex = 7;
            // 
            // plUsuarios
            // 
            plUsuarios.BackColor = SystemColors.Control;
            plUsuarios.Controls.Add(txtId);
            plUsuarios.Controls.Add(lbId);
            plUsuarios.Controls.Add(mkdSenha);
            plUsuarios.Controls.Add(lbNome);
            plUsuarios.Controls.Add(btSalvar);
            plUsuarios.Controls.Add(lbEmail);
            plUsuarios.Controls.Add(txtEmail);
            plUsuarios.Controls.Add(lbSenha);
            plUsuarios.Controls.Add(txtNome);
            plUsuarios.Location = new Point(12, 12);
            plUsuarios.Name = "plUsuarios";
            plUsuarios.Size = new Size(228, 215);
            plUsuarios.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(7, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(213, 23);
            txtId.TabIndex = 8;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(7, 4);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 7;
            lbId.Text = "ID";
            // 
            // mkdSenha
            // 
            mkdSenha.Location = new Point(7, 154);
            mkdSenha.Name = "mkdSenha";
            mkdSenha.PasswordChar = '*';
            mkdSenha.Size = new Size(213, 23);
            mkdSenha.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txtFiltro);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(260, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 61);
            panel1.TabIndex = 9;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(11, 29);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(242, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtrar por Nome/Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 548);
            Controls.Add(panel1);
            Controls.Add(plUsuarios);
            Controls.Add(grdUsuarios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            plUsuarios.ResumeLayout(false);
            plUsuarios.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btSalvar;
        private Label lbNome;
        private Label lbEmail;
        private Label lbSenha;
        private TextBox txtNome;
        private TextBox txtEmail;
        private DataGridView grdUsuarios;
        private Panel plUsuarios;
        private MaskedTextBox mkdSenha;
        private TextBox txtId;
        private Label lbId;
        private Panel panel1;
        private TextBox txtFiltro;
        private Label label1;
    }
}
