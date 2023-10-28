using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers.Holerite
{
    public class HoleriteController : Controller
    {
        private readonly string vstr_title = "Holerite";

        // GET: Holerite
        public ActionResult Consulta()
        {
            ViewBag.Title = vstr_title;
            return View();
        }
    }
}