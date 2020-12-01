using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaBanco.Domain
{
    public class Afiliado : Pessoa, IEntity
    {
        [Required]
        public int VendasNoMes { get; set; }
        [Required]
        [MaxLength(50)]
        public string Cargo { get; set; }
        /*
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(20)]
        public string Cpf { get; set; }
        */
    }
}
