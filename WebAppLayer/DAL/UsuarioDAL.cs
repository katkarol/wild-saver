
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class UsuarioDAL : IDisposable
    {
        public UsuarioDAL()
        {
            contexto = new WildSaverContext();
        }
        private  WildSaverContext contexto;


        public  void Adicionar(Usuario u)
        {
            contexto.Usuarios.Add(u);
            contexto.SaveChanges();
        }

        public  void Atualizar(Usuario u)
        {
            contexto.Update(u);
            contexto.SaveChanges();

        }

        public  void Dispose()
        {
            contexto.Dispose();
        }

        public  IList<Usuario> Lista()
        {
            return contexto.Usuarios.ToList();
        }

        public  void Remover(Usuario u)
        {
            contexto.Usuarios.Remove(u);
            contexto.SaveChanges();

        }
        public  Usuario BuscarUsuarioSenha(Usuario u)
        {

            using (contexto)
            {
                return contexto.Usuarios.FirstOrDefault(usuario => usuario.Login == u.Login && usuario.Senha == u.Senha);

            }
        }
        public  int ExisteLogin (string login)
        {

            using (contexto)
            {
                return contexto.Usuarios.Where(usuario => usuario.Login == login).Count(); 

            }
        }
    }
}