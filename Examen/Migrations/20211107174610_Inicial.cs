using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Alumnos",
                columns: table => new
                {
                    IDAlumno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Alumnos", x => x.IDAlumno);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Materias",
                columns: table => new
                {
                    IDMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Materias", x => x.IDMateria);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Notas",
                columns: table => new
                {
                    IDNota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAlumno = table.Column<int>(type: "int", nullable: true),
                    IDMateria = table.Column<int>(type: "int", nullable: true),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Notas", x => x.IDNota);
                    table.ForeignKey(
                        name: "FK_Tbl_Notas_Tbl_Alumnos_IDAlumno",
                        column: x => x.IDAlumno,
                        principalTable: "Tbl_Alumnos",
                        principalColumn: "IDAlumno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Notas_Tbl_Materias_IDMateria",
                        column: x => x.IDMateria,
                        principalTable: "Tbl_Materias",
                        principalColumn: "IDMateria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Notas_IDAlumno",
                table: "Tbl_Notas",
                column: "IDAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Notas_IDMateria",
                table: "Tbl_Notas",
                column: "IDMateria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Notas");

            migrationBuilder.DropTable(
                name: "Tbl_Alumnos");

            migrationBuilder.DropTable(
                name: "Tbl_Materias");
        }
    }
}
