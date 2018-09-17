using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class OrdemController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ClasseDAL dal = new ClasseDAL();
            IList<Classe> classes = dal.Lista();
            ViewBag.Classes = classes;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Ordem ordem)
        {
            return RedirectToAction("Cadastrar", "Familia");
        }

    }
}