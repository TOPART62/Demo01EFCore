using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExercice01.Migrations
{
    public partial class ColumnNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Complement",
                table: "Adresses",
                newName: "complement");

            migrationBuilder.RenameColumn(
                name: "Commune",
                table: "Adresses",
                newName: "commune");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Adresses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NumeroVoie",
                table: "Adresses",
                newName: "numero_voie");

            migrationBuilder.RenameColumn(
                name: "IntituleVoie",
                table: "Adresses",
                newName: "intitule_voie");

            migrationBuilder.RenameColumn(
                name: "CodePostal",
                table: "Adresses",
                newName: "code_postal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "complement",
                table: "Adresses",
                newName: "Complement");

            migrationBuilder.RenameColumn(
                name: "commune",
                table: "Adresses",
                newName: "Commune");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Adresses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "numero_voie",
                table: "Adresses",
                newName: "NumeroVoie");

            migrationBuilder.RenameColumn(
                name: "intitule_voie",
                table: "Adresses",
                newName: "IntituleVoie");

            migrationBuilder.RenameColumn(
                name: "code_postal",
                table: "Adresses",
                newName: "CodePostal");
        }
    }
}
