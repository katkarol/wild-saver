using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class AnimalRegiao
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int RegiaoId{ get; set; }
        public Regiao Regiao { get; set; }
    }
}