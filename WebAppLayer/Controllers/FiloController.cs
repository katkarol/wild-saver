using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class FiloController : Controller
    {
      
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Filo filo)
        {
            return RedirectToAction("Cadastrar", "Classe");

        }
    }
}