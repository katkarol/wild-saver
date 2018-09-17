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
    public class FamiliaController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            IList<Ordem> ordens = OrdemDAL.Lista();
            ViewBag.Ordens = ordens;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Familia familia)
        {
            FamiliaBL.AdicionarFamilia(familia);
            return RedirectToAction("Cadastrar", "Genero");

        }
    }
}