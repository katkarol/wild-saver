using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.BusinessLogic;

namespace WebAppLayer.Controllers
{
    public class ClasseController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            IList<Filo> filos = FiloDAL.Lista();
            ViewBag.Filos = filos;

            return View(new Classe());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Classe classe)
        {
            ClasseBL.AdicionarClasse(classe);
            return RedirectToAction("Cadastrar", "Ordem");
        }

    }
}