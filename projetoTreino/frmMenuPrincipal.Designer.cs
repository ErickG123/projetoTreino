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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btClientes = new Button();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Highlight;
            flowLayoutPanel1.Controls.Add(btClientes);
            flowLayoutPanel1.Location = new Point(12, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 64);
            flowLayoutPanel1.TabIndex = 1;
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
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            FormClosed += frmMenuPrincipal_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosGeraisToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btClientes;
    }
}