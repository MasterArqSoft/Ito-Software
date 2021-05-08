using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false, comment: "Identificador de la persona")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la persona"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nombre de la persona"),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Apellido de la persona"),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false, comment: "Identificador del departamento"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Tipo de documento")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "PersonaId", "Apellido", "DepartamentoId", "Nombre", "NumeroDocumento", "TipoDocumento" },
                values: new object[,]
                {
                    { 1, "Candelario Restrepo", 1, "Erwing 01", "76018789", "Cedula" },
                    { 2, "Candelario Restrepo", 2, "Erwing 02", "76018789", "Cedula" },
                    { 3, "Candelario Restrepo", 3, "Erwing 03", "76018789", "Cedula" },
                    { 4, "Candelario Restrepo", 4, "Erwing 04", "76018789", "Cedula" },
                    { 5, "Candelario Restrepo", 5, "Erwing 05", "76018789", "Cedula" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
