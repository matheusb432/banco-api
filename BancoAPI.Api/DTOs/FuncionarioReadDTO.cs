using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.DTOs
{
    public class FuncionarioReadDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
    }
}
