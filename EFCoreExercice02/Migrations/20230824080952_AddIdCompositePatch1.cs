using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExercice02.Migrations
{
    public partial class AddIdCompositePatch1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "booking_room",
                type: "int",
                nullable: false,
                comment: "-- id --",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "-- id de la reservation --")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "booking_room",
                type: "int",
                nullable: false,
                comment: "-- id de la reservation --",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "-- id --")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
