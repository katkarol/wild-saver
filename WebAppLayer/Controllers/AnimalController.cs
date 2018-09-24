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
        protected AnimalController()
        {
             generoDAL = new GeneroDAL();

        }
        private GeneroDAL generoDAL;

        [HttpGet]
        public ActionResult Cadastrar()
        {
            IList<Genero> generos = generoDAL.Lista();
            ViewBag.Generos = generos;
            ViewBag.Regioes = new List<AnimalRegiao>();
            return View(new List<AnimalRegiao>());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Animal animal, List<AnimalRegiao> regioes)
        {
            try
            {
                return RedirectToAction("Index", "Home");

            }
            catch (Exception)
            {
                return View(animal);
            }
        }
    }
}