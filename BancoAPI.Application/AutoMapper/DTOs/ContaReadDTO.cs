namespace SistemaBanco.Api.DTOs
{
    public class ContaReadDTO
    {
        public string TipoConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
    }
}