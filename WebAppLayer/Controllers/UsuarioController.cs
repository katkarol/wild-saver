using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.Models;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario u)
        {
            return View();
           // return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult CriarConta()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CriarConta(Usuario usuario)
        {
            usuario.PapelUsuario = PapelUsuario.Usuario;
            return View();
            // return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult CadastarFuncionario()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CadastarFuncionario(Usuario usuario)
        {
            usuario.PapelUsuario = PapelUsuario.Funcionario;
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult RedefinirSenha()
        {

            return View();
        }
        [HttpPost]
        public ActionResult RedefinirSenha(Usuario usuario)
        {
            return RedirectToAction("Login", "Usuario");
        }


    }
}