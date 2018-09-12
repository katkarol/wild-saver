using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class AnimalRegiao
    {
        public int AnimalId { get; set; }
        [Required]
        public Animal Animal { get; set; }
        public int RegiaoId{ get; set; }
        [Required]

        public Regiao Regiao { get; set; }
    }
}