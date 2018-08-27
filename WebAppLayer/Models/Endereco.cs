using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Endereco
    {
        public int ID { get; set; }
        [Required (ErrorMessage ="A rua deve ser informada")]
        public string Rua { get; set; }
        [Required (ErrorMessage = "O bairro deve ser informado")]
        public string Bairro { get; set; }
        [Required (ErrorMessage = "A cidade deve ser informada")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O estado deve ser informado")]
        public string UF { get; set; }
        [Required(ErrorMessage = "O país deve ser informado")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "O CEP deve ser informado")]
        public string CEP { get; set; }
    }
}