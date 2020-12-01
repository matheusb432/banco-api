using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaBanco.Domain
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
            Contas = new List<Conta>();
        }

        [ForeignKey("ClienteRefId")]
        public ICollection<Conta> Contas { get; set; }
    }
}
