using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaBanco.Domain
{
    public class Corretora : Entity
    {
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }
        [Required]
        public bool IsInternacional { get; set; }
        [Required]
        public double RendaBruta { get; set; }
        [Required]
        public double LucroLiquido { get; set; }
    }
}
