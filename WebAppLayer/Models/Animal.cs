using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Animal
    {
        public int ID { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string NomePopular { get; set; }
    }
}