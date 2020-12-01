using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBanco.Infra.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Contas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Contas",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
