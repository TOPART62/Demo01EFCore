using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoRelationsBlog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteUri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Archived = table.Column<bool>(type: "bit", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_posts_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "Name", "SiteUri" },
                values: new object[] { 1, "Skyblog de Jennifer", "https://www.skyblog.com/jennifer" });

            migrationBuilder.InsertData(
                table: "blogs",
                columns: new[] { "Id", "Name", "SiteUri" },
                values: new object[] { 2, "EFCore Docs", "https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes" });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Id", "Archived", "BlogId", "Content", "PublishedOn", "Title" },
                values: new object[] { 1, false, 1, "Mon premier post skyblog !!!! <3", new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1178), "Coucou" });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Id", "Archived", "BlogId", "Content", "PublishedOn", "Title" },
                values: new object[] { 2, false, 1, "Je suis triste.", new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1207), "Brandon m'a largué..." });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "Id", "Archived", "BlogId", "Content", "PublishedOn", "Title" },
                values: new object[] { 3, false, 2, "A one-to-many relationship is made up from:\nOne or more primary or alternate key properties on the principal entity; that is the \"one\" end of the relationship. For example, Blog.Id.\nOne or more foreign key properties on the dependent entity; that is the \"many\" end of the relationship. For example, Post.BlogId.\nOptionally, a collection navigation on the principal entity referencing the dependent entities. For example, Blog.Posts.\nOptionally, a reference navigation on the dependent entity referencing the principal entity.", new DateTime(2023, 8, 22, 12, 5, 23, 812, DateTimeKind.Local).AddTicks(1209), "Required one-to-many" });

            migrationBuilder.CreateIndex(
                name: "IX_posts_BlogId",
                table: "posts",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}
