using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.DTOs
{
    public class ContaReadDTO
    {
        public string TipoConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
    }
}
