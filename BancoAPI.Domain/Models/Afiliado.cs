using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBanco.Domain
{
    public class Afiliado : Pessoa
    { 
        [Required]
        public int VendasNoMes { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cargo { get; set; }
    }
}