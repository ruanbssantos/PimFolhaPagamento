using Newtonsoft.Json.Linq;
using PimFolhaPagamento.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers.AutoBusca
{
    public class AutoBuscaController : Controller
    {

        Conexao conexao = new Conexao();

        // GET: AutoBusca
        public ActionResult Field_Cbo()
        {
            // Extraia os parâmetros do objeto JSON
            //string parametro1 = Request["parametro1"].ToString();
            //string parametro2 = Request["parametro2"].ToString();
            ResultadoBancoDados dadosBanco = null;

            conexao.AbrirConexao();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_Cbo";
                cmd.Parameters.Add("@vstr_tipoOper", System.Data.SqlDbType.VarChar).Value = "SEL";
                cmd.Parameters.Add("@vstr_acao", System.Data.SqlDbType.NVarChar).Value = "Field_Cbo";

                SqlDataReader rs = cmd.ExecuteReader();
                dadosBanco = RsToArray.CriarJSONDoDataReader(rs);

                rs.Close();
            }
            conexao.FecharConexao();
             

            return Json(dadosBanco, JsonRequestBehavior.AllowGet);

        }
    }
}