using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoRelationsBlog.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogTag",
                columns: table => new
                {
                    BlogsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTag", x => new { x.BlogsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_BlogTag_blogs_BlogsId",
                        column: x => x.BlogsId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTag_tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 13, 48, 58, 256, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 13, 48, 58, 256, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 13, 48, 58, 256, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.CreateIndex(
                name: "IX_BlogTag_TagsId",
                table: "BlogTag",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.DropTable(
                name: "tags");

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
        }
    }
}
