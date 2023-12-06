namespace projetoTreino
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel2 = new Panel();
            mkdSenha = new MaskedTextBox();
            cbLembrarSenha = new CheckBox();
            lbSenha = new Label();
            txtNome = new TextBox();
            lbNome = new Label();
            btLogin = new Button();
            btSair = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(mkdSenha);
            panel2.Controls.Add(cbLembrarSenha);
            panel2.Controls.Add(lbSenha);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(lbNome);
            panel2.Location = new Point(12, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 115);
            panel2.TabIndex = 1;
            // 
            // mkdSenha
            // 
            mkdSenha.Location = new Point(3, 64);
            mkdSenha.Name = "mkdSenha";
            mkdSenha.PasswordChar = '*';
            mkdSenha.Size = new Size(194, 23);
            mkdSenha.TabIndex = 5;
            // 
            // cbLembrarSenha
            // 
            cbLembrarSenha.AutoSize = true;
            cbLembrarSenha.Location = new Point(3, 93);
            cbLembrarSenha.Name = "cbLembrarSenha";
            cbLembrarSenha.Size = new Size(160, 19);
            cbLembrarSenha.TabIndex = 4;
            cbLembrarSenha.Text = "Lembrar  Usuário e Senha";
            cbLembrarSenha.UseVisualStyleBackColor = true;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(3, 44);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 2;
            lbSenha.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(0, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(197, 23);
            txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(3, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome";
            // 
            // btLogin
            // 
            btLogin.Image = (Image)resources.GetObject("btLogin.Image");
            btLogin.Location = new Point(238, 216);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(71, 86);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.TextAlign = ContentAlignment.BottomCenter;
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btSair
            // 
            btSair.Image = (Image)resources.GetObject("btSair.Image");
            btSair.Location = new Point(315, 217);
            btSair.Name = "btSair";
            btSair.Size = new Size(71, 85);
            btSair.TabIndex = 3;
            btSair.Text = "Sair";
            btSair.TextAlign = ContentAlignment.BottomCenter;
            btSair.UseVisualStyleBackColor = true;
            btSair.Click += btSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 317);
            Controls.Add(pictureBox1);
            Controls.Add(btSair);
            Controls.Add(btLogin);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lbSenha;
        private TextBox txtNome;
        private Label lbNome;
        private CheckBox cbLembrarSenha;
        private Button btLogin;
        private Button btSair;
        private PictureBox pictureBox1;
        private MaskedTextBox mkdSenha;
    }
}