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
                name: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    begin_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "room",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: false),
                    beds_number = table.Column<int>(type: "int", nullable: false),
                    room_rate = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "booking",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "client",
                columns: new[] { "id", "first_name", "last_name", "tel" },
                values: new object[] { 1, "Toto", "Toto", "0101010101" });

            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "id", "beds_number", "BookingId", "room_rate", "status" },
                values: new object[] { 1, 1, null, 125.50m, 0 });

            migrationBuilder.InsertData(
                table: "booking",
                columns: new[] { "id", "begin_date", "client_id", "end_date", "status" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_booking_client_id",
                table: "booking",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_BookingId",
                table: "room",
                column: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "room");

            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "client");
        }
    }
}
