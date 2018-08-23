using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Models
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }


    }
}