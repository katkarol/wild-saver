using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppLayer.Models;

namespace WebAppLayer.DAL
{
    public class WildSaverContext : DbContext
    {
        internal DbSet<Denuncia> Denuncias { get; set; }
        internal DbSet<Usuario> Usuarios { get; set; }
}
}