using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.Filtros;


namespace WebAppLayer.Controllers
{
    [AutorizacaoFuncionarioFilter]
    public class AnimalController : Controller
    {
        

        [HttpGet]
        public ActionResult Cadastrar()
        {
            GeneroDAL generoDAL = new GeneroDAL();
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