namespace projetoTreino
{
    partial class frmMenuPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosGeraisToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            flpBotoes = new FlowLayoutPanel();
            btClientes = new Button();
            btProdutos = new Button();
            btVendas = new Button();
            menuStrip1.SuspendLayout();
            flpBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosGeraisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosGeraisToolStripMenuItem
            // 
            cadastrosGeraisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, clientesToolStripMenuItem });
            cadastrosGeraisToolStripMenuItem.Name = "cadastrosGeraisToolStripMenuItem";
            cadastrosGeraisToolStripMenuItem.Size = new Size(106, 20);
            cadastrosGeraisToolStripMenuItem.Text = "Cadastros Gerais";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(119, 22);
            usuariosToolStripMenuItem.Text = "Usuários";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(119, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // flpBotoes
            // 
            flpBotoes.BackColor = SystemColors.Highlight;
            flpBotoes.Controls.Add(btClientes);
            flpBotoes.Controls.Add(btProdutos);
            flpBotoes.Controls.Add(btVendas);
            flpBotoes.Location = new Point(12, 27);
            flpBotoes.Name = "flpBotoes";
            flpBotoes.Size = new Size(776, 64);
            flpBotoes.TabIndex = 1;
            // 
            // btClientes
            // 
            btClientes.FlatStyle = FlatStyle.Flat;
            btClientes.ForeColor = SystemColors.Highlight;
            btClientes.Image = Properties.Resources.clientes;
            btClientes.Location = new Point(3, 3);
            btClientes.Name = "btClientes";
            btClientes.Size = new Size(75, 61);
            btClientes.TabIndex = 0;
            btClientes.UseVisualStyleBackColor = true;
            btClientes.Click += btClientes_Click;
            // 
            // btProdutos
            // 
            btProdutos.BackColor = Color.Transparent;
            btProdutos.FlatStyle = FlatStyle.Flat;
            btProdutos.ForeColor = SystemColors.Highlight;
            btProdutos.Image = Properties.Resources.produtos;
            btProdutos.Location = new Point(84, 3);
            btProdutos.Name = "btProdutos";
            btProdutos.Size = new Size(75, 61);
            btProdutos.TabIndex = 2;
            btProdutos.UseVisualStyleBackColor = false;
            btProdutos.Click += btProdutos_Click;
            // 
            // btVendas
            // 
            btVendas.BackColor = Color.Transparent;
            btVendas.FlatStyle = FlatStyle.Flat;
            btVendas.ForeColor = SystemColors.Highlight;
            btVendas.Image = Properties.Resources.venda1;
            btVendas.Location = new Point(165, 3);
            btVendas.Name = "btVendas";
            btVendas.Size = new Size(75, 61);
            btVendas.TabIndex = 3;
            btVendas.UseVisualStyleBackColor = false;
            btVendas.Click += btVendas_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpBotoes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            FormClosed += frmMenuPrincipal_FormClosed;
            Shown += frmMenuPrincipal_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flpBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosGeraisToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private FlowLayoutPanel flpBotoes;
        private Button btClientes;
        private Button btProdutos;
        private Button btVendas;
    }
}