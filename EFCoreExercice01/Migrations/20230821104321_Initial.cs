using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExercice01.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroVoie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntituleVoie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "CodePostal", "Commune", "Complement", "IntituleVoie", "NumeroVoie" },
                values: new object[] { 1, 99999, "turlututu", "", "rue tutu", "22 bis" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
