using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTreino
{
    public static class AtualizarBanco
    {
        public static string strConnection = @"DataSource=localhost; 
                                     Database=C:\DBFire\TREINO.FBD; 
                                     username=sysdba; 
                                     password=masterkey";
        public static FbConnection conn = new FbConnection(strConnection);

        public static void AtualizaBanco()
        {
            List<string> listaAtualizacoes = new List<string>();
            FbCommand cmd;

            foreach (string s in listaAtualizacoes)
            {
                string[] info = s.Split('|');
                switch (info[0])
                {
                    case "C": // Adicionar Campo
                        // Verificar se o Campo Existe antes de criar
                        if (!campoExiste(info[1], info[2]))
                        {
                            try
                            {
                                cmd = new FbCommand(info[3], conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Projeto Teste");
                                return;
                            }
                        }
                        break;
                    case "T": // Adicionar Tabela
                        // Verificar se a Tabela Existe antes de criar
                        if (!tabelaExiste(info[1]))
                        {
                            try
                            {
                                cmd = new FbCommand(info[3], conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Projeto Teste");
                                return;
                            }
                        }
                        break;
                    case "TR": // Adicionar Trigger
                        // Verificar se a Trigger Existe antes de criar
                        if (!triggerExiste(info[1]))
                        {
                            try
                            {
                                cmd = new FbCommand(info[3], conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Projeto Teste");
                                return;
                            }
                        }
                        break;
                    case "G": // Adicionar Generator
                        // Verificar se o Generator Existe antes de criar
                        if (!generatorExiste(info[1]))
                        {
                            try
                            {
                                cmd = new FbCommand(info[3], conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Projeto Teste");
                                return;
                            }
                        }
                        break;
                    case "FK": // Adicionar Foreign Key
                        // Verificar se a Foreign Key Existe antes de criar
                        if (!foreignKeyExiste(info[1]))
                        {
                            try
                            {
                                cmd = new FbCommand(info[3], conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Projeto Teste");
                                return;
                            }
                        }
                        break;
                }
            }
        }

        public static bool campoExiste(string tabela, string campo) {
            string sql =
            @"
                SELECT RDB$FIELD_NAME,RDB$RELATION_NAME
                FROM RDB$RELATION_FIELDS
                WHERE RDB$SYSTEM_FLAG = 0
                AND RDB$RELATION_NAME = @tabela
                AND RDB$FIELD_NAME = @campo
            ";

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tabela", tabela);
            cmd.Parameters.AddWithValue("@campo", campo);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool tabelaExiste(string nomeTabela)
        {
            string sql = @"SELECT * FROM RDB$RELATIONS WHERE RDB$RELATION_NAME = @tabela";

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tabela", nomeTabela);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool triggerExiste(string nomeTrigger)
        {
            string sql = @"SELECT * FROM RDB$TRIGGERS WHERE RDB$TRIGGER_NAME = @trigger";

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@trigger", nomeTrigger);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool generatorExiste(string nomeGenerator)
        {
            string sql = @"SELECT * FROM RDB$GENERATORS  WHERE RDB$GENERATOR_NAME = @generator";

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@generator", nomeGenerator);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt.Rows.Count > 0;
        }

        public static bool foreignKeyExiste(string nomeFK)
        {
            string sql = @"SELECT * FROM RDB$INDEX_SEGMENTS  WHERE RDB$INDEX_NAME  = @foreignKey";

            FbCommand cmd = new FbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@foreignKey", nomeFK);

            DataTable dt = new DataTable();
            FbDataAdapter dataAdapter = new FbDataAdapter(sql, conn);
            dataAdapter.Fill(dt);

            return dt.Rows.Count > 0;
        }
    }
}
