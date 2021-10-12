using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Relacion_Directivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directivos_Empleados_SubordinadoId",
                table: "Directivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Directivos_Empresas_DirigeId",
                table: "Directivos");

            migrationBuilder.DropIndex(
                name: "IX_Directivos_DirigeId",
                table: "Directivos");

            migrationBuilder.DropIndex(
                name: "IX_Directivos_SubordinadoId",
                table: "Directivos");

            migrationBuilder.DropColumn(
                name: "DirigeId",
                table: "Directivos");

            migrationBuilder.DropColumn(
                name: "SubordinadoId",
                table: "Directivos");

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Directivos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Directivos_EmpleadoId",
                table: "Directivos",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Directivos_Empleados_EmpleadoId",
                table: "Directivos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directivos_Empleados_EmpleadoId",
                table: "Directivos");

            migrationBuilder.DropIndex(
                name: "IX_Directivos_EmpleadoId",
                table: "Directivos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Directivos");

            migrationBuilder.AddColumn<int>(
                name: "DirigeId",
                table: "Directivos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubordinadoId",
                table: "Directivos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Directivos_DirigeId",
                table: "Directivos",
                column: "DirigeId");

            migrationBuilder.CreateIndex(
                name: "IX_Directivos_SubordinadoId",
                table: "Directivos",
                column: "SubordinadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directivos_Empleados_SubordinadoId",
                table: "Directivos",
                column: "SubordinadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Directivos_Empresas_DirigeId",
                table: "Directivos",
                column: "DirigeId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
