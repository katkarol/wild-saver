using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLayer.BusinessLogic;
using WebAppLayer.DAL;
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
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
           UsuarioBL.ValidacoesLogin(usuario);
            return RedirectToAction("Index", "Home");

        }
        [HttpGet]
        public ActionResult CriarConta()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarConta(Usuario usuario)
        {
            
            usuario.PapelUsuario = PapelUsuario.Usuario;
            UsuarioBL.AdicionarConta(usuario);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult CadastarFuncionario()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastarFuncionario(Usuario usuario)
        {
            usuario.PapelUsuario = PapelUsuario.Funcionario;
            UsuarioBL.AdicionarConta(usuario);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult RedefinirSenha()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RedefinirSenha(Usuario usuario)
        {
            return RedirectToAction("Login", "Usuario");
        }


    }
}