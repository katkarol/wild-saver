
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
        public UsuarioDAL()
        {
            contexto = new WildSaverContext();
        }
        private static WildSaverContext contexto;


        public static void Adicionar(Usuario u)
        {
            contexto.Usuarios.Add(u);
            contexto.SaveChanges();
        }

        public static void Atualizar(Usuario u)
        {
            contexto.Update(u);
            contexto.SaveChanges();

        }

        public static void Dispose()
        {
            contexto.Dispose();
        }

        public static IList<Usuario> LerProdutos()
        {
            return contexto.Usuarios.ToList();
        }

        public static void Remover(Usuario u)
        {
            contexto.Usuarios.Remove(u);
            contexto.SaveChanges();

        }
        public static Usuario BuscarUsuarioSenha(Usuario u)
        {

            using (contexto)
            {
                return contexto.Usuarios.FirstOrDefault(usuario => usuario.Login == u.Login && usuario.Senha == u.Senha);

            }
        }
    }
}