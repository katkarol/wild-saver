using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Animal
    {
        public Filo Filo { get; set; }
        public Classe Classe { get; set; }
        public Ordem Ordem { get; set; }
        public Familia Familia { get; set; }
        public Genero Genero { get; set; }
        public string Descricao { get; set; }
        public Endereco LocalPredominante { get; set; }

    }
}