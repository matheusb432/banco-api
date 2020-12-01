using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.MessageService
{
    public class Message
    {
        public string Text { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double Cash { get; set; }
    }
}
