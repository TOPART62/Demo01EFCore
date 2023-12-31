﻿// <auto-generated />
using Demo01EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreExercice01.Migrations
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

            modelBuilder.Entity("EFCoreExercice01.Models.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CodePostal")
                        .HasColumnType("int")
                        .HasColumnName("code_postal");

                    b.Property<string>("Commune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("commune");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("complement");

                    b.Property<string>("IntituleVoie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("intitule_voie");

                    b.Property<string>("NumeroVoie")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("numero_voie");

                    b.HasKey("Id");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CodePostal = 99999,
                            Commune = "turlututu",
                            Complement = "",
                            IntituleVoie = "rue tutu",
                            NumeroVoie = "22 bis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
