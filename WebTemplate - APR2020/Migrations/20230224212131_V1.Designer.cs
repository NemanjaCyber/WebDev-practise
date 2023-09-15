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
    [Migration("20230224212131_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Polica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MaxDVD")
                        .HasColumnType("int");

                    b.Property<int?>("MojKlubID")
                        .HasColumnType("int");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrenutnoDVD")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MojKlubID");

                    b.ToTable("Police");
                });

            modelBuilder.Entity("Models.VideoKlub", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Klubovi");
                });

            modelBuilder.Entity("Models.Polica", b =>
                {
                    b.HasOne("Models.VideoKlub", "MojKlub")
                        .WithMany("Police")
                        .HasForeignKey("MojKlubID");

                    b.Navigation("MojKlub");
                });

            modelBuilder.Entity("Models.VideoKlub", b =>
                {
                    b.Navigation("Police");
                });
#pragma warning restore 612, 618
        }
    }
}
