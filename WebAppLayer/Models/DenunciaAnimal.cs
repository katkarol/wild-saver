using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class DenunciaAnimal
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int DenunciaId { get; set; }
        public Denuncia Denuncia { get; set; }
    }
}