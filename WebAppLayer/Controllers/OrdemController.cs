using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.BusinessLogic;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class OrdemController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            IList<Classe> classes = ClasseDAL.Lista();
            ViewBag.Classes = classes;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Ordem ordem)
        {
            OrdemBL.AdicionarOrdem(ordem);
            return RedirectToAction("Cadastrar", "Familia");
        }

    }
}