using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBanco.Domain
{
    public class Corretora : Entity
    {
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Nome { get; set; }

        [Required]
        public bool IsInternacional { get; set; }

        [Required]
        public double RendaBruta { get; set; }

        [Required]
        public double LucroLiquido { get; set; }
    }
}