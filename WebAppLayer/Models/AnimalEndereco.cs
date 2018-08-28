using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class AnimalEndereco
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}