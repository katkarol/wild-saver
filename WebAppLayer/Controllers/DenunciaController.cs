using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;
using WebAppLayer.Models;
using WebAppLayer.Filtros;
using WebAppLayer.BusinessLogic;

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
        [ValidateAntiForgeryToken]
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
        [AutorizacaoFuncionarioFilter]
        public ActionResult Vizualizar()
        {
            DenunciaBL denunciaBL = new DenunciaBL();
            IList<Denuncia> denuncias = denunciaBL.Lista();

            return View(denuncias);
        }

    }
}