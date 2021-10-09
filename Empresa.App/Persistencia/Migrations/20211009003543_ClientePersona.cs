using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class ClientePersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PersonaId",
                table: "Empleados",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PersonaId",
                table: "Clientes",
                column: "PersonaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Personas_PersonaId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Personas_PersonaId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PersonaId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PersonaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Clientes");
        }
    }
}
