using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo01EFCore.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 1000, "xxx@xxx.com", "Default", "Default", "0101010101" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
