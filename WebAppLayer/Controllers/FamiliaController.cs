using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class FamiliaController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.Familia = new Familia();
            OrdemDAL dal = new OrdemDAL();
            IList<Ordem> ordens = dal.Lista();
            ViewBag.Ordens = ordens;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Familia familia)
        {
            return RedirectToAction("Cadastrar", "Genero");

        }
    }
}