using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBanco.Domain
{
    public class Funcionario : Pessoa
    {
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cargo { get; set; }
    }
}