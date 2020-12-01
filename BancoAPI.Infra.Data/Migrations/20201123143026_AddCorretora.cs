using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBanco.Infra.Migrations
{
    public partial class AddCorretora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corretoras",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsInternacional = table.Column<bool>(type: "bit", nullable: false),
                    RendaBruta = table.Column<double>(type: "float", nullable: false),
                    LucroLiquido = table.Column<double>(type: "float", nullable: false),
                    DataDeRegistro = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretoras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corretoras");
        }
    }
}
