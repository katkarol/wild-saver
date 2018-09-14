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
            ViewBag.Animal = new Animal();
            GeneroDAL dal = new GeneroDAL();
            IList<Genero> generos = dal.Lista();
            ViewBag.Generos = generos;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Animal animal)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}