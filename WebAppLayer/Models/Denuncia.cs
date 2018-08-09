using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Denuncia
    {
        public int ID { get; set; }
        public DateTime DtaHrDenuncia { get; set; }
        public Endereco Local { get; set; }
        public Animal Animal { get; set; }
        public string DescricaoAnimal { get; set; }
    }
}