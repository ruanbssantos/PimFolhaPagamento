using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PimFolhaPagamento.Classes
{
    public class Conexao
    {
        public SqlConnection conn;

        public void AbrirConexao() 
        {
            try
            {
                conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cstr_conexao"].ConnectionString);
                conn.Open();
            }
            catch (Exception ex) 
            { 
                throw new Exception("Erro ao abrir a conexão: " +  ex.Message);
            }
        }

        public void FecharConexao() 
        {
            try
            {
                if (conn != null)
                { 
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }
}