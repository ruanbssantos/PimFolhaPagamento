using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers.Funcionario
{
    public class FuncionarioController : Controller
    {
        private readonly string vstr_title = "Funcionário";

        // GET: Funcionario
        public ActionResult Consulta()
        {
            ViewBag.Title = vstr_title;
            return View();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Title = vstr_title + " - Cadastro";
            return View("Formulario");
        }

        public ActionResult Alteracao()
        {
            ViewBag.Title = vstr_title + " - Alteração";
            return View("Formulario");
        }
    }
}