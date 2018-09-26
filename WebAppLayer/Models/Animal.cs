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
        [Required(ErrorMessage = "O Genero deve ser informado")]
        public Genero Genero { get; set; }
        [Required(ErrorMessage = "Deve ser feita a descrição do animal")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Nome Popular deve ser informado")]
        public string NomePopular { get; set; }

        public List<Regiao> Regioes { get; set; }
    }
}