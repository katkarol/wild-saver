using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppLayer.Models
{
    public class Noticia
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "O Título da noticia deve ser informado")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Resumo da noticia deve ser informado")]
        public string Resumo { get; set; }
        public DateTime DataPublicacao { get; set; }
        [Required(ErrorMessage = "O Link da noticia deve ser informado")]
        public string Link { get; set; }
    }
}