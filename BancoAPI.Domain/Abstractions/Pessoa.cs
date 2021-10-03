using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBanco.Domain
{
    public abstract class Pessoa : Entity, IPessoa
    {
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Cpf { get; set; }
    }
}