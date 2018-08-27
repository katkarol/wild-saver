using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Models
{
    public class Usuario
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "O usuário deve ser informado")]
        public string Login { get; set; }
        [Required (ErrorMessage ="A senha deve ser informada")]
        public string Senha { get; set; }
        [Required]
        public Pessoa PessoaUsuaria { get; set; }
        public PapelUsuario PapelUsuario { get; set; }

    }


}