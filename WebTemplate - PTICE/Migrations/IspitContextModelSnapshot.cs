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

            modelBuilder.Entity("Models.NepoznataPtica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Nepoznate");
                });

            modelBuilder.Entity("Models.Osobina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vrednost")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Osobine");
                });

            modelBuilder.Entity("Models.Podrucje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Podrucja");
                });

            modelBuilder.Entity("Models.Ptica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ptice");
                });

            modelBuilder.Entity("Models.Vidjenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int?>("PodrucjeID")
                        .HasColumnType("int");

                    b.Property<int?>("PticaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PodrucjeID");

                    b.HasIndex("PticaID");

                    b.ToTable("Vidjenja");
                });

            modelBuilder.Entity("NepoznataPticaOsobina", b =>
                {
                    b.Property<int>("NepoznataID")
                        .HasColumnType("int");

                    b.Property<int>("OsobineID")
                        .HasColumnType("int");

                    b.HasKey("NepoznataID", "OsobineID");

                    b.HasIndex("OsobineID");

                    b.ToTable("NepoznataPticaOsobina");
                });

            modelBuilder.Entity("OsobinaPtica", b =>
                {
                    b.Property<int>("OsobineID")
                        .HasColumnType("int");

                    b.Property<int>("PticaID")
                        .HasColumnType("int");

                    b.HasKey("OsobineID", "PticaID");

                    b.HasIndex("PticaID");

                    b.ToTable("OsobinaPtica");
                });

            modelBuilder.Entity("Models.Vidjenje", b =>
                {
                    b.HasOne("Models.Podrucje", "Podrucje")
                        .WithMany("Vidjenja")
                        .HasForeignKey("PodrucjeID");

                    b.HasOne("Models.Ptica", "Ptica")
                        .WithMany("Vidjenja")
                        .HasForeignKey("PticaID");

                    b.Navigation("Podrucje");

                    b.Navigation("Ptica");
                });

            modelBuilder.Entity("NepoznataPticaOsobina", b =>
                {
                    b.HasOne("Models.NepoznataPtica", null)
                        .WithMany()
                        .HasForeignKey("NepoznataID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Osobina", null)
                        .WithMany()
                        .HasForeignKey("OsobineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OsobinaPtica", b =>
                {
                    b.HasOne("Models.Osobina", null)
                        .WithMany()
                        .HasForeignKey("OsobineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Ptica", null)
                        .WithMany()
                        .HasForeignKey("PticaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Podrucje", b =>
                {
                    b.Navigation("Vidjenja");
                });

            modelBuilder.Entity("Models.Ptica", b =>
                {
                    b.Navigation("Vidjenja");
                });
#pragma warning restore 612, 618
        }
    }
}
