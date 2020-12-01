using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.DTOs
{
    public class CorretoraReadDTO
    {
        public string Nome { get; set; }
        public bool IsInternacional { get; set; }
        public double RendaBruta { get; set; }
        public double LucroLiquido { get; set; }
    }
}
