using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBanco.Domain
{
    public class Conta : Entity
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string TipoConta { get; set; }

        [Required]
        public double Saldo { get; set; }

        public double Limite { get; set; }

        [Required]
        public long ClienteRefId { get; set; }

        public void GetNameOf()
        {
            Console.WriteLine($"{nameof(ClienteRefId)}");
        }
    }
}