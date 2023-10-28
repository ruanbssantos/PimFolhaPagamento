using PimFolhaPagamento.Classes;
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
            // Atualize o caminho de navegação
            ViewBag.Breadcrumb = new List<BreadcrumbItem>
            {
                new BreadcrumbItem("Página Inicial", Url.Action("Index", "Home")),
            };

            return View();
        }

        public ActionResult Consulta()
        {
            ViewBag.Breadcrumb = new List<BreadcrumbItem>
            {
                new BreadcrumbItem("Página Inicial", Url.Action("Index", "Home")),
                new BreadcrumbItem("Funcionário", Url.Action("Consulta", "Consulta")),
            };
            return View();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Breadcrumb = new List<BreadcrumbItem>
            {
                new BreadcrumbItem("Página Inicial", Url.Action("Index", "Home")),
                new BreadcrumbItem("Funcionário", Url.Action("Consulta", "Funcionario")),
                new BreadcrumbItem("Cadastro", Url.Action("Cadastro", "Funcionario")),
            };
            return View();
        }

        //// Ação para inserir um funcionário
        //[HttpPost]
        //public JsonResult Inserir(Funcionario funcionario)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        return Json(new { success = true, message = "Funcionário inserido com sucesso!" });
        //    }

        //    return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });
        //}

    }
}