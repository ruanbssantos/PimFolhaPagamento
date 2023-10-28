﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PimFolhaPagamento.Controllers.Cbo
{
    public class CboController : Controller
    { 
        private readonly string vstr_title = "CBO";

        // GET: Cbo
        public ActionResult Consulta()
        {
            ViewBag.Title = "CBO";
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