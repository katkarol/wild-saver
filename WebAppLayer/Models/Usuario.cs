using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Pessoa PessoaUsuaria { get; set; }
    }

  
}