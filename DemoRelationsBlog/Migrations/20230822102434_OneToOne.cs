using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoRelationsBlog.Migrations
{
    public partial class OneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogHeaders_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 24, 33, 891, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 24, 33, 891, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 24, 33, 891, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.CreateIndex(
                name: "IX_blogHeaders_BlogId",
                table: "blogHeaders",
                column: "BlogId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogHeaders");

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1209));
        }
    }
}
