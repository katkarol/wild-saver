﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Genero
    {
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public Familia Familia { get; set; }
        [Required]
        public string NomePopular { get; set; }

    }
}