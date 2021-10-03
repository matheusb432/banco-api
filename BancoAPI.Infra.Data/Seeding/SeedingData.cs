using Microsoft.EntityFrameworkCore;
using SistemaBanco.Domain;

namespace BancoAPI.Infra.Data.Seeding
{
    public static class SeedingData
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            SeedCorretoras(modelBuilder);

            SeedFuncionarios(modelBuilder);

            SeedAfiliados(modelBuilder);

            SeedClientes(modelBuilder);

            SeedContas(modelBuilder);
        }

        private static void SeedCorretoras(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Corretora>().HasData(
                    new Corretora { Id = 1, Nome = "Corretora 01", IsInternacional = false, RendaBruta = 10000000.50, LucroLiquido = 35000.50 },
                    new Corretora { Id = 2, Nome = "Corretora 02", IsInternacional = true, RendaBruta = 10000.50, LucroLiquido = 25 },
                    new Corretora { Id = 3, Nome = "Corretora 03", IsInternacional = false, RendaBruta = 100000000, LucroLiquido = 525000 }
                    );

        private static void SeedFuncionarios(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Funcionario>().HasData(
                    new Funcionario { Id = 1, Cargo = "Atendente", Nome = "Funcionario 01", Cpf = "123.456.789-00" },
                    new Funcionario { Id = 2, Cargo = "Chefe", Nome = "Funcionario 02", Cpf = "456.456.789-00" },
                    new Funcionario { Id = 3, Cargo = "Analista", Nome = "Funcionario 03", Cpf = "789.456.789-00" }
                    );

        private static void SeedAfiliados(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Afiliado>().HasData(
                    new Afiliado { Id = 1, Cargo = "Vendedor 01", Nome = "Afiliado 01", Cpf = "123.456.777-00", VendasNoMes = 150 },
                    new Afiliado { Id = 2, Cargo = "Vendedor 02", Nome = "Afiliado 02", Cpf = "777.456.789-00", VendasNoMes = 250 },
                    new Afiliado { Id = 3, Cargo = "Vendedor 03", Nome = "Afiliado 03", Cpf = "123.777.789-00", VendasNoMes = 400 }
                    );

        private static void SeedClientes(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Cliente>().HasData(
                    new Cliente { Id = 1, Nome = "Funcionario 01", Cpf = "111.456.789-00" },
                    new Cliente { Id = 2, Nome = "Funcionario 02", Cpf = "123.222.789-00" },
                    new Cliente { Id = 3, Nome = "Funcionario 03", Cpf = "123.456.333-00" },
                    new Cliente { Id = 4, Nome = "Funcionario 04", Cpf = "423.456.789-44" },
                    new Cliente { Id = 5, Nome = "Funcionario 05", Cpf = "155.556.789-00" }
                    );

        private static void SeedContas(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Conta>().HasData(
                    new Conta { Id = 1, TipoConta = "credit", Saldo = 15000, Limite = 500, ClienteRefId = 1 },
                    new Conta { Id = 2, TipoConta = "debit", Saldo = 20000, Limite = 1500, ClienteRefId = 2 },
                    new Conta { Id = 3, TipoConta = "debit", Saldo = 30000, Limite = 2500, ClienteRefId = 3 },
                    new Conta { Id = 4, TipoConta = "debit", Saldo = 10000, Limite = 200, ClienteRefId = 4 },
                    new Conta { Id = 5, TipoConta = "credit", Saldo = 50000, Limite = 300, ClienteRefId = 5 }
                    );
    }
}