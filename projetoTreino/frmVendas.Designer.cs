namespace projetoTreino
{
    partial class frmVendas
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
            flpAtalhos = new FlowLayoutPanel();
            btCliente = new Button();
            btVendedor = new Button();
            btFechar = new Button();
            btQuantidade = new Button();
            plRegistroProduto = new Panel();
            label1 = new Label();
            txtQuantidade = new TextBox();
            txtCodigoProduto = new TextBox();
            label2 = new Label();
            flpAtalhos.SuspendLayout();
            plRegistroProduto.SuspendLayout();
            SuspendLayout();
            // 
            // flpAtalhos
            // 
            flpAtalhos.BackColor = SystemColors.Highlight;
            flpAtalhos.Controls.Add(btCliente);
            flpAtalhos.Controls.Add(btVendedor);
            flpAtalhos.Controls.Add(btFechar);
            flpAtalhos.Controls.Add(btQuantidade);
            flpAtalhos.Location = new Point(308, 476);
            flpAtalhos.Name = "flpAtalhos";
            flpAtalhos.Size = new Size(457, 121);
            flpAtalhos.TabIndex = 0;
            // 
            // btCliente
            // 
            btCliente.BackColor = Color.Transparent;
            btCliente.FlatAppearance.BorderSize = 0;
            btCliente.FlatStyle = FlatStyle.Flat;
            btCliente.ForeColor = Color.WhiteSmoke;
            btCliente.Location = new Point(3, 3);
            btCliente.Name = "btCliente";
            btCliente.Size = new Size(106, 23);
            btCliente.TabIndex = 0;
            btCliente.Text = "[F1] Cliente";
            btCliente.TextAlign = ContentAlignment.MiddleLeft;
            btCliente.UseVisualStyleBackColor = false;
            // 
            // btVendedor
            // 
            btVendedor.BackColor = Color.Transparent;
            btVendedor.FlatAppearance.BorderSize = 0;
            btVendedor.FlatStyle = FlatStyle.Flat;
            btVendedor.ForeColor = Color.WhiteSmoke;
            btVendedor.Location = new Point(115, 3);
            btVendedor.Name = "btVendedor";
            btVendedor.Size = new Size(106, 23);
            btVendedor.TabIndex = 1;
            btVendedor.Text = "[F2] Vendedor";
            btVendedor.TextAlign = ContentAlignment.MiddleLeft;
            btVendedor.UseVisualStyleBackColor = true;
            // 
            // btFechar
            // 
            btFechar.BackColor = Color.Transparent;
            btFechar.FlatAppearance.BorderSize = 0;
            btFechar.FlatStyle = FlatStyle.Flat;
            btFechar.ForeColor = Color.WhiteSmoke;
            btFechar.Location = new Point(227, 3);
            btFechar.Name = "btFechar";
            btFechar.Size = new Size(109, 23);
            btFechar.TabIndex = 2;
            btFechar.Text = "[F4] Fechar";
            btFechar.UseVisualStyleBackColor = false;
            // 
            // btQuantidade
            // 
            btQuantidade.BackColor = Color.Transparent;
            btQuantidade.FlatAppearance.BorderSize = 0;
            btQuantidade.FlatStyle = FlatStyle.Flat;
            btQuantidade.ForeColor = Color.WhiteSmoke;
            btQuantidade.Location = new Point(342, 3);
            btQuantidade.Name = "btQuantidade";
            btQuantidade.Size = new Size(109, 23);
            btQuantidade.TabIndex = 3;
            btQuantidade.Text = "[X] Quantidade";
            btQuantidade.TextAlign = ContentAlignment.MiddleLeft;
            btQuantidade.UseVisualStyleBackColor = false;
            // 
            // plRegistroProduto
            // 
            plRegistroProduto.Controls.Add(label2);
            plRegistroProduto.Controls.Add(txtCodigoProduto);
            plRegistroProduto.Controls.Add(txtQuantidade);
            plRegistroProduto.Controls.Add(label1);
            plRegistroProduto.Location = new Point(12, 378);
            plRegistroProduto.Name = "plRegistroProduto";
            plRegistroProduto.Size = new Size(290, 219);
            plRegistroProduto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Quantidade (X)";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(16, 32);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(133, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(155, 32);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(120, 23);
            txtCodigoProduto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 14);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Cód. Produto";
            // 
            // frmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 609);
            Controls.Add(plRegistroProduto);
            Controls.Add(flpAtalhos);
            Name = "frmVendas";
            Text = "Vendas";
            WindowState = FormWindowState.Maximized;
            Shown += frmVendas_Shown;
            flpAtalhos.ResumeLayout(false);
            plRegistroProduto.ResumeLayout(false);
            plRegistroProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAtalhos;
        private Button btCliente;
        private Button btVendedor;
        private Button btFechar;
        private Button btQuantidade;
        private Panel plRegistroProduto;
        private Label label1;
        private Label label2;
        private TextBox txtCodigoProduto;
        private TextBox txtQuantidade;
    }
}