using System;

namespace SistemaBanco.Domain
{
    public interface IEntity
    {
        DateTimeOffset DataDeRegistro { get; }
        long Id { get; set; }
    }
}