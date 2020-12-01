using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBanco.Infra.Migrations
{
    public partial class InitForeignCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas");

            migrationBuilder.AddColumn<long>(
                name: "Conta",
                table: "Contas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_Conta",
                table: "Contas",
                column: "Conta");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_Conta",
                table: "Contas",
                column: "Conta",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_Conta",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_Conta",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "Conta",
                table: "Contas");

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
