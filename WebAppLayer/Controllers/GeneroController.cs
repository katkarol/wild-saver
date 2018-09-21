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
            FamiliaDAL familiaDAL = new FamiliaDAL();
            IList<Familia> familias = familiaDAL.Lista();
            ViewBag.Familias = familias;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Genero genero)
        {
            try
            {
                ViewBag.Erro = "";
                GeneroBL generoBL = new GeneroBL();
                generoBL.AdicionarGenero(genero);
                return RedirectToAction("Cadastrar", "Animal");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View(genero);
             
            }


        }
    }
}