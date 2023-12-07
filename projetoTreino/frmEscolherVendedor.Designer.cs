namespace projetoTreino
{
    partial class frmEscolherVendedor
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
            grdVendedores = new DataGridView();
            btOk = new Button();
            ((System.ComponentModel.ISupportInitialize)grdVendedores).BeginInit();
            SuspendLayout();
            // 
            // grdVendedores
            // 
            grdVendedores.AllowUserToAddRows = false;
            grdVendedores.AllowUserToDeleteRows = false;
            grdVendedores.AllowUserToResizeRows = false;
            grdVendedores.BackgroundColor = Color.WhiteSmoke;
            grdVendedores.BorderStyle = BorderStyle.None;
            grdVendedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVendedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVendedores.GridColor = SystemColors.ControlDark;
            grdVendedores.Location = new Point(12, 12);
            grdVendedores.MultiSelect = false;
            grdVendedores.Name = "grdVendedores";
            grdVendedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdVendedores.RowHeadersVisible = false;
            grdVendedores.Size = new Size(227, 150);
            grdVendedores.TabIndex = 8;
            // 
            // btOk
            // 
            btOk.Location = new Point(217, 415);
            btOk.Name = "btOk";
            btOk.Size = new Size(75, 23);
            btOk.TabIndex = 9;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // frmEscolherVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 450);
            Controls.Add(btOk);
            Controls.Add(grdVendedores);
            Name = "frmEscolherVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escolher Vendedor";
            Shown += frmEscolherVendedor_Shown;
            ((System.ComponentModel.ISupportInitialize)grdVendedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdVendedores;
        private Button btOk;
    }
}