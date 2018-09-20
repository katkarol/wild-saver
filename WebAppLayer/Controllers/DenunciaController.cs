using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.Models;

namespace WebAppLayer.Controllers
{
    public class DenunciaController : Controller
    {
       

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Denuncia denuncia)
        {
            try
            {
                return RedirectToAction("Index", "Home");

            }
            catch (Exception)
            {

                return View(denuncia);
            }
        } 
    }
}