using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Pessoa
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public PapelUsuario PapelUsuario { get; set; }
        public string CPF { get; set; }
        public Usuario Usuario { get; set; }


    }
}