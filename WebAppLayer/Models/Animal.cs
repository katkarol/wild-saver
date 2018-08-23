using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public Genero Genero { get; set; }
        public string Descricao { get; set; }
        public Endereco Endereco { get; set; }
        public string NomePopular { get; set; }
    }
}