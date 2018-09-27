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
    [AutorizacaoUsuarioFilter]
    public class DenunciaController : Controller
    {
       

        [HttpGet]
        public ActionResult Cadastrar()
        {
            AnimalDAL animalDAL = new AnimalDAL();
            IList<Animal> animais = animalDAL.Lista();
            ViewBag.Animais = animais;

            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Denuncia denuncia)
        {
            try
            {
                ViewBag.Erro = "";
                return RedirectToAction("Index", "Home");

            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View(denuncia);
            }
        } 
    }
}