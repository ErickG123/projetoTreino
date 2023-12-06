using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTreino
{
    public partial class frmLogin : Form
    {
        private string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        private FbConnection conn;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            conn = new FbConnection(strConnection);
            string sql = @"SELECT * FROM usuarios WHERE nome = @nome AND password = @senha";

            FbDataReader dr = null;

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@senha", mkdSenha.Text);

            conn.Open();

            try
            {
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    frmMenuPrincipal frm = new frmMenuPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos", "Projeto Treino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
