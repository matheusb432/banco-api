using Microsoft.EntityFrameworkCore;
using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBanco.Infra
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {

        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Afiliado> Afiliados { get; set; }
        public DbSet<Corretora> Corretoras { get; set; }
    }
}
