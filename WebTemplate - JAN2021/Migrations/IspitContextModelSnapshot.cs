﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace WebTemplate.Migrations
{
    [DbContext(typeof(IspitContext))]
    partial class IspitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("Models.MeteoroloskiPodaci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<int>("KolicinaPadavina")
                        .HasColumnType("int");

                    b.Property<string>("NazivMeseca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuncaniDani")
                        .HasColumnType("int");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GradID");

                    b.ToTable("MeteoroloskiPodaci");
                });

            modelBuilder.Entity("Models.MeteoroloskiPodaci", b =>
                {
                    b.HasOne("Models.Grad", "Grad")
                        .WithMany("MeteoroloskiPodaci")
                        .HasForeignKey("GradID");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("Models.Grad", b =>
                {
                    b.Navigation("MeteoroloskiPodaci");
                });
#pragma warning restore 612, 618
        }
    }
}
