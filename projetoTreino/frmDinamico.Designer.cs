namespace projetoTreino
{
    partial class frmDinamico
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
            btCancelar = new Button();
            btSalvar = new Button();
            SuspendLayout();
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(713, 415);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 0;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(632, 415);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 1;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // frmDinamico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSalvar);
            Controls.Add(btCancelar);
            Name = "frmDinamico";
            Text = "SimpleReflectionForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btCancelar;
        private Button btSalvar;
    }
}