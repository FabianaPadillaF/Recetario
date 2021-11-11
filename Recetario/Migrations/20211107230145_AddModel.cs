using Microsoft.EntityFrameworkCore.Migrations;

namespace Recetario.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    RecetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombredeReceta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiempodePreparacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porciones = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.RecetaId);
                    table.ForeignKey(
                        name: "FK_Receta_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receta_DepartamentoId",
                table: "Receta",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receta");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
