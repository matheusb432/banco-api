using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaBanco.Infra.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Contas",
                newName: "ClienteRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas",
                newName: "IX_Contas_ClienteRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteRefId",
                table: "Contas",
                column: "ClienteRefId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteRefId",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "ClienteRefId",
                table: "Contas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Contas_ClienteRefId",
                table: "Contas",
                newName: "IX_Contas_ClienteId");

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
