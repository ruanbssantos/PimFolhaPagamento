using PimFolhaPagamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Ação para inserir um funcionário
        [HttpPost]
        public JsonResult Inserir(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {

                return Json(new { success = true, message = "Funcionário inserido com sucesso!" });
            }

            return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });
        }

    }
}