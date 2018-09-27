using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.DAL;

namespace WebAppLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NoticiaDAL noticiaDAL = new NoticiaDAL();
            ViewBag.Noticias= noticiaDAL.Lista().Take(4).ToList();

            return View();
        }

        
        public ActionResult Sobre()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
        

        public ActionResult Contato()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}