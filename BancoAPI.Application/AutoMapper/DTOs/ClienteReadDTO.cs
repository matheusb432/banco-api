using SistemaBanco.Domain;
using System.Collections.Generic;

namespace SistemaBanco.Api.DTOs
{
    public class ClienteReadDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<Conta> Contas { get; set; }
    }
}