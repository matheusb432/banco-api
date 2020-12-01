using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.DTOs
{
    public class ClienteReadDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<Conta> Contas { get; set; }
    }
}
