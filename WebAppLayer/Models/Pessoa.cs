using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Models
{
    public class Pessoa
    {
        [Required (ErrorMessage ="O nome deve ser informado")]
        public string NomeCompleto { get; set; }
        [Required (ErrorMessage ="A data de nascimento deve ser informado")]
        public DateTime DataNascimento { get; set; }
        [Required]
        public Endereco Endereco { get; set; }
        [Required (ErrorMessage = "O CPF deve ser informado")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O Email deve ser informado")]
        public string Email { get; set; }


    }
}