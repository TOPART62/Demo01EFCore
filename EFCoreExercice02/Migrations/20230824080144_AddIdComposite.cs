using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreExercice02.Migrations
{
    public partial class AddIdComposite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_booking_room",
                table: "booking_room");

            migrationBuilder.DeleteData(
                table: "booking_room",
                keyColumns: new[] { "booking_id", "room_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "booking_room",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "-- id de la reservation --")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "booking",
                type: "datetime2",
                nullable: false,
                comment: "-- date fin de reservation --",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "-- date foin de reservation --");

            migrationBuilder.AddPrimaryKey(
                name: "PK_booking_room",
                table: "booking_room",
                column: "id");

            migrationBuilder.InsertData(
                table: "booking_room",
                columns: new[] { "id", "booking_id", "room_id", "update_date" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_booking_room",
                table: "booking_room");

            migrationBuilder.DropColumn(
                name: "id",
                table: "booking_room");

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "booking",
                type: "datetime2",
                nullable: false,
                comment: "-- date foin de reservation --",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "-- date fin de reservation --");

            migrationBuilder.AddPrimaryKey(
                name: "PK_booking_room",
                table: "booking_room",
                columns: new[] { "booking_id", "room_id" });
        }
    }
}
