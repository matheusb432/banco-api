using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.DTOs
{
    public class AfiliadoReadDTO
    {
        public int VendasNoMes { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
