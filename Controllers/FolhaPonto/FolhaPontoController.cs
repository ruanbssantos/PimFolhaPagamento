using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers.Horas
{
    public class FolhaPontoController : Controller
    {
        private readonly string vstr_title = "Folha de Ponto";

        // GET: Horas
        public ActionResult Consulta()
        {
            ViewBag.Title = vstr_title;
            return View();
        }
    }
}