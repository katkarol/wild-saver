using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Genero
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Familia Familia { get; set; }
        public string NomePopular { get; set; }

    }
}