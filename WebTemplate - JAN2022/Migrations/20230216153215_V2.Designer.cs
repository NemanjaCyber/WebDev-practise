﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace WebTemplate.Migrations
{
    [DbContext(typeof(IspitContext))]
    [Migration("20230216153215_V2")]
    partial class V2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrOcena")
                        .HasColumnType("int");

                    b.Property<string>("Kategorija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdukcijaID")
                        .HasColumnType("int");

                    b.Property<int>("UkupnaOcena")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProdukcijaID");

                    b.ToTable("Filmovi");
                });

            modelBuilder.Entity("Models.ProdukcijskaKuca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProdukcijskeKuce");
                });

            modelBuilder.Entity("Models.Film", b =>
                {
                    b.HasOne("Models.ProdukcijskaKuca", "Produkcija")
                        .WithMany("Filmovi")
                        .HasForeignKey("ProdukcijaID");

                    b.Navigation("Produkcija");
                });

            modelBuilder.Entity("Models.ProdukcijskaKuca", b =>
                {
                    b.Navigation("Filmovi");
                });
#pragma warning restore 612, 618
        }
    }
}
