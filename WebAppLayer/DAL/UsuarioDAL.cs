
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class UsuarioDAL
    {
        public void Adicionar(Usuario u)
        {
            using (WildSaverContext contexto = new WildSaverContext())
            {
                contexto.Usuarios.Add(u);
                contexto.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using (WildSaverContext contexto = new WildSaverContext())
            {
                contexto.Update(u);
                contexto.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (WildSaverContext contexto = new WildSaverContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public void Remover(Usuario u)
        {
            using (WildSaverContext contexto = new WildSaverContext())
            {
                contexto.Usuarios.Remove(u);
                contexto.SaveChanges();
            }
        }

        public Usuario BuscarUsuarioSenha(Usuario u)
        {

            using (WildSaverContext contexto = new WildSaverContext())
            {
                return contexto.Usuarios.FirstOrDefault(usuario => usuario.Login == u.Login && usuario.Senha == u.Senha);

            }
        }

        public int ExisteLogin(string login)
        {

            using (WildSaverContext contexto = new WildSaverContext())
            {
                return contexto.Usuarios.Where(usuario => usuario.Login == login).Count();
            }
        }
    }
}