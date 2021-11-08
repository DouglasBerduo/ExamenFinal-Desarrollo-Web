using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Migrations
{
    public partial class result : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Notas_Tbl_Alumnos_IDAlumno",
                table: "Tbl_Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Notas_Tbl_Materias_IDMateria",
                table: "Tbl_Notas");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Notas_IDAlumno",
                table: "Tbl_Notas");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Notas_IDMateria",
                table: "Tbl_Notas");

            migrationBuilder.AddColumn<string>(
                name: "resultado",
                table: "Tbl_Notas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resultado",
                table: "Tbl_Notas");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Notas_IDAlumno",
                table: "Tbl_Notas",
                column: "IDAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Notas_IDMateria",
                table: "Tbl_Notas",
                column: "IDMateria");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Notas_Tbl_Alumnos_IDAlumno",
                table: "Tbl_Notas",
                column: "IDAlumno",
                principalTable: "Tbl_Alumnos",
                principalColumn: "IDAlumno",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Notas_Tbl_Materias_IDMateria",
                table: "Tbl_Notas",
                column: "IDMateria",
                principalTable: "Tbl_Materias",
                principalColumn: "IDMateria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
