using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBanco.Domain
{
    public abstract class Entity : IEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTimeOffset DataDeRegistro { get; protected set; } = DateTimeOffset.UtcNow;
    }
}