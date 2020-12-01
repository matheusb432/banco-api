using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaBanco.Domain
{
    public abstract class Entity : IEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTimeOffset DataDeRegistro { get; protected set; } = DateTimeOffset.UtcNow;
    }
}
