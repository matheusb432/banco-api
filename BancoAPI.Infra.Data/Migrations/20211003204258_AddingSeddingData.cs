using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoAPI.Infra.Data.Migrations
{
    public partial class AddingSeddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Afiliados",
                columns: new[] { "Id", "Cargo", "Cpf", "DataDeRegistro", "Nome", "VendasNoMes" },
                values: new object[,]
                {
                    { 1L, "Vendedor 01", "123.456.777-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 0, 0, 0, 0)), "Afiliado 01", 150 },
                    { 2L, "Vendedor 02", "777.456.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(1222), new TimeSpan(0, 0, 0, 0, 0)), "Afiliado 02", 250 },
                    { 3L, "Vendedor 03", "123.777.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(1225), new TimeSpan(0, 0, 0, 0, 0)), "Afiliado 03", 400 }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataDeRegistro", "Nome" },
                values: new object[,]
                {
                    { 1L, "111.456.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(3735), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 01" },
                    { 2L, "123.222.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 02" },
                    { 3L, "123.456.333-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4061), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 03" },
                    { 4L, "423.456.789-44", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 04" },
                    { 5L, "155.556.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(4065), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 05" }
                });

            migrationBuilder.InsertData(
                table: "Corretoras",
                columns: new[] { "Id", "DataDeRegistro", "IsInternacional", "LucroLiquido", "Nome", "RendaBruta" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9063), new TimeSpan(0, 0, 0, 0, 0)), false, 35000.5, "Corretora 01", 10000000.5 },
                    { 2L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9867), new TimeSpan(0, 0, 0, 0, 0)), true, 25.0, "Corretora 02", 10000.5 },
                    { 3L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 134, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)), false, 525000.0, "Corretora 03", 100000000.0 }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Cargo", "Cpf", "DataDeRegistro", "Nome" },
                values: new object[,]
                {
                    { 1L, "Atendente", "123.456.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8400), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 01" },
                    { 2L, "Chefe", "456.456.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 02" },
                    { 3L, "Analista", "789.456.789-00", new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 135, DateTimeKind.Unspecified).AddTicks(8920), new TimeSpan(0, 0, 0, 0, 0)), "Funcionario 03" }
                });

            migrationBuilder.InsertData(
                table: "Contas",
                columns: new[] { "Id", "ClienteRefId", "DataDeRegistro", "Limite", "Saldo", "TipoConta" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(6454), new TimeSpan(0, 0, 0, 0, 0)), 500.0, 15000.0, "credit" },
                    { 2L, 2L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 0, 0, 0, 0)), 1500.0, 20000.0, "debit" },
                    { 3L, 3L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 0, 0, 0, 0)), 2500.0, 30000.0, "debit" },
                    { 4L, 4L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, 0, 0, 0, 0)), 200.0, 10000.0, "debit" },
                    { 5L, 5L, new DateTimeOffset(new DateTime(2021, 10, 3, 20, 42, 58, 136, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 0, 0, 0, 0)), 300.0, 50000.0, "credit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Afiliados",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Afiliados",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Afiliados",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Contas",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Contas",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Contas",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Contas",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Contas",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Corretoras",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Corretoras",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Corretoras",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
