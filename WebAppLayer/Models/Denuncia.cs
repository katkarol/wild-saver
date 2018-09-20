using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppLayer.Models.Enums;

namespace WebAppLayer.Models
{
    public class Denuncia
    {
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        
        public DateTime DataInsercao { get; set; }
        [Required]
        public DateTime DataDaDenuncia { get; set; }
        [Required]
        public Endereco Local { get; set; }
        [Required]
        public string DescricaoAnimal { get; set; }
        public bool Anonimo { get; set; }
        public EstadoDenuncia EstadoDenuncia { get; set; }
    }
}