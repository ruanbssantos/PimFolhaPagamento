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
        // GET: AutoBusca
        public ActionResult Field_Cbo()
        {
            // Extraia os parâmetros do objeto JSON
            //string parametro1 = Request["parametro1"].ToString();
            //string parametro2 = Request["parametro2"].ToString();
            ResultadoBancoDados dadosBanco = null; 

            using (SqlConnection vstr_conexao = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cstr_conexao"].ConnectionString))
            {
                vstr_conexao.Open();

                using (SqlCommand vobj_command = new SqlCommand())
                {
                    vobj_command.Connection = vstr_conexao;
                    vobj_command.CommandType = System.Data.CommandType.StoredProcedure;
                    vobj_command.CommandText = "SP_Cbo";
                    vobj_command.Parameters.Add("@vstr_tipoOper", System.Data.SqlDbType.VarChar).Value = "SEL";
                    vobj_command.Parameters.Add("@vstr_acao", System.Data.SqlDbType.NVarChar).Value = "Field_Cbo";

                    SqlDataReader vobj_rs = vobj_command.ExecuteReader();
                    dadosBanco = RsToArray.CriarJSONDoDataReader(vobj_rs);
                    
                    vobj_rs.Close();
                }

                vstr_conexao.Close();
            }


            return Json(dadosBanco, JsonRequestBehavior.AllowGet);

        }
    }
}