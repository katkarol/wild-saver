using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Noticia
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Link { get; set; }
    }
}