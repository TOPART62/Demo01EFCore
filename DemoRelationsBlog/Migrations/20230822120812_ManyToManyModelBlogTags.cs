using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoRelationsBlog.Migrations
{
    public partial class ManyToManyModelBlogTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTag");

            migrationBuilder.CreateTable(
                name: "blogTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogTags_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blogTags_tags_TagId",
                        column: x => x.TagId,
                        principalTable: "tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.CreateIndex(
                name: "IX_blogTags_BlogId",
                table: "blogTags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_blogTags_TagId",
                table: "blogTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogTags");

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
    }
}
