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
    public class GeneroController : Controller
    {
        
        [HttpGet]
        public ActionResult Cadastrar()
        {
            IList<Familia> familias = FamiliaDAL.Lista();
            ViewBag.Familias = familias;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Genero genero)
        {
            GeneroBL.AdicionarGenero(genero);
            return RedirectToAction("Cadastrar", "Animal");

        }
    }
}