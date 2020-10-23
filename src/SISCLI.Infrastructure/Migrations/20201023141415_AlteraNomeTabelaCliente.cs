using Microsoft.EntityFrameworkCore.Migrations;

namespace SISCLI.Infrastructure.Migrations
{
    public partial class AlteraNomeTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Cliente",
                table: "Tb_Cliente");

            migrationBuilder.RenameTable(
                name: "Tb_Cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Tb_Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Cliente",
                table: "Tb_Cliente",
                column: "ClienteId");
        }
    }
}
