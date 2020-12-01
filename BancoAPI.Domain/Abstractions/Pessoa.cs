using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaBanco.Domain
{
    public abstract class Pessoa : Entity, IPessoa
    {
        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(20)]
        public string Cpf { get; set; }
    }
}
