using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExercice02.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booking_room",
                columns: table => new
                {
                    booking_id = table.Column<int>(type: "int", nullable: false, comment: "-- id de la reservation --"),
                    room_id = table.Column<int>(type: "int", nullable: false, comment: "-- id de la chambre reservee--"),
                    update_date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "-- date de mise à jour de la reservation --")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_room", x => new { x.booking_id, x.room_id });
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "-- id du client --")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "-- nom du client --"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "-- prenom du client --"),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "-- telephone du client --")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "-- id de la chambre --")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: false, comment: "-- status de la chambre --"),
                    beds_number = table.Column<int>(type: "int", nullable: false, comment: "-- numero de la chambre --"),
                    room_rate = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false, comment: "-- tarif de la chambre --")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "-- id de la reservation --")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    begin_date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "-- date debut de reservation --"),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "-- date foin de reservation --"),
                    status = table.Column<int>(type: "int", nullable: false, comment: "-- status de la reservation --"),
                    client_id = table.Column<int>(type: "int", nullable: false, comment: "-- id du client de la reservation --")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_client_client_id",
                        column: x => x.client_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "booking_room",
                columns: new[] { "booking_id", "room_id", "update_date" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "client",
                columns: new[] { "id", "first_name", "last_name", "tel" },
                values: new object[] { 1, "Toto", "Toto", "0101010101" });

            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "id", "beds_number", "room_rate", "status" },
                values: new object[] { 1, 1, 125.50m, 0 });

            migrationBuilder.InsertData(
                table: "booking",
                columns: new[] { "id", "begin_date", "client_id", "end_date", "status" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_booking_client_id",
                table: "booking",
                column: "client_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "booking_room");

            migrationBuilder.DropTable(
                name: "room");

            migrationBuilder.DropTable(
                name: "client");
        }
    }
}
