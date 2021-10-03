using System;

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