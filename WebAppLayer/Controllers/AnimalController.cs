using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class AnimalController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            GeneroDAL generoDAL = new GeneroDAL();
            IList<Genero> generos = generoDAL.Lista();
            ViewBag.Generos = generos;
            ViewBag.Regioes = new List<Regiao>();
            return View(new List<Regiao>());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Animal animal, List<Regiao> regioes)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}