using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Pessoa PessoaUsuaria { get; set; }
        public PapelUsuario PapelUsuario { get; set; }

    }


}