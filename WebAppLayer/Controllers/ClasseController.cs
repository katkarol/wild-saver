using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class ClasseController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Classe = new Classe();
            FiloDAL dal = new FiloDAL();
            IList<Filo> filos = dal.Lista();
            ViewBag.Filos = filos;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Classe classe)
        {
            return RedirectToAction("Cadastrar", "Ordem");
        }

    }
}