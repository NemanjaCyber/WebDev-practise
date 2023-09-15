﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTemplate.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabrike",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrike", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Silosi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oznaka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kapacitet = table.Column<int>(type: "int", nullable: false),
                    TrenutnaPopunjenost = table.Column<int>(type: "int", nullable: false),
                    FabrikaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Silosi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Silosi_Fabrike_FabrikaID",
                        column: x => x.FabrikaID,
                        principalTable: "Fabrike",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Silosi_FabrikaID",
                table: "Silosi",
                column: "FabrikaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Silosi");

            migrationBuilder.DropTable(
                name: "Fabrike");
        }
    }
}
