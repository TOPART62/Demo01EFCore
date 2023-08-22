﻿// <auto-generated />
using System;
using DemoRelationsBlog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoRelationsBlog.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DemoRelationsBlog.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Skyblog de Jennifer",
                            SiteUri = "https://www.skyblog.com/jennifer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "EFCore Docs",
                            SiteUri = "https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes"
                        });
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.BlogHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId")
                        .IsUnique();

                    b.ToTable("blogHeaders");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.BlogTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("TagId");

                    b.ToTable("blogTags");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Archived = false,
                            BlogId = 1,
                            Content = "Mon premier post skyblog !!!! <3",
                            PublishedOn = new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8261),
                            Title = "Coucou"
                        },
                        new
                        {
                            Id = 2,
                            Archived = false,
                            BlogId = 1,
                            Content = "Je suis triste.",
                            PublishedOn = new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8294),
                            Title = "Brandon m'a largué..."
                        },
                        new
                        {
                            Id = 3,
                            Archived = false,
                            BlogId = 2,
                            Content = "A one-to-many relationship is made up from:\nOne or more primary or alternate key properties on the principal entity; that is the \"one\" end of the relationship. For example, Blog.Id.\nOne or more foreign key properties on the dependent entity; that is the \"many\" end of the relationship. For example, Post.BlogId.\nOptionally, a collection navigation on the principal entity referencing the dependent entities. For example, Blog.Posts.\nOptionally, a reference navigation on the dependent entity referencing the principal entity.",
                            PublishedOn = new DateTime(2023, 8, 22, 14, 8, 11, 962, DateTimeKind.Local).AddTicks(8296),
                            Title = "Required one-to-many"
                        });
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.BlogHeader", b =>
                {
                    b.HasOne("DemoRelationsBlog.Models.Blog", "Blog")
                        .WithOne("Header")
                        .HasForeignKey("DemoRelationsBlog.Models.BlogHeader", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.BlogTag", b =>
                {
                    b.HasOne("DemoRelationsBlog.Models.Blog", "Blog")
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoRelationsBlog.Models.Tag", "Tag")
                        .WithMany("BlogTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.Post", b =>
                {
                    b.HasOne("DemoRelationsBlog.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.Blog", b =>
                {
                    b.Navigation("BlogTags");

                    b.Navigation("Header");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("DemoRelationsBlog.Models.Tag", b =>
                {
                    b.Navigation("BlogTags");
                });
#pragma warning restore 612, 618
        }
    }
}
