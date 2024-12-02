using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_website.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Huurders",
                columns: table => new
                {
                    HuurderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huurders", x => x.HuurderId);
                });

            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantId);
                });

            migrationBuilder.CreateTable(
                name: "Voertuigen",
                columns: table => new
                {
                    VoertuigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Merk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kenteken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voertuigen", x => x.VoertuigId);
                });

            migrationBuilder.CreateTable(
                name: "Abonnementen",
                columns: table => new
                {
                    AbonnementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KlantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonnementen", x => x.AbonnementId);
                    table.ForeignKey(
                        name: "FK_Abonnementen_Klanten_KlantId",
                        column: x => x.KlantId,
                        principalTable: "Klanten",
                        principalColumn: "KlantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schades",
                columns: table => new
                {
                    SchadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoertuigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schades", x => x.SchadeId);
                    table.ForeignKey(
                        name: "FK_Schades_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medewerkers",
                columns: table => new
                {
                    MedewerkerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbonnementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medewerkers", x => x.MedewerkerId);
                    table.ForeignKey(
                        name: "FK_Medewerkers_Abonnementen_AbonnementId",
                        column: x => x.AbonnementId,
                        principalTable: "Abonnementen",
                        principalColumn: "AbonnementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HuurAanvragen",
                columns: table => new
                {
                    HuurAanvraagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HuurderId = table.Column<int>(type: "int", nullable: false),
                    VoertuigId = table.Column<int>(type: "int", nullable: false),
                    MedewerkerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuurAanvragen", x => x.HuurAanvraagId);
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Huurders_HuurderId",
                        column: x => x.HuurderId,
                        principalTable: "Huurders",
                        principalColumn: "HuurderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Medewerkers_MedewerkerId",
                        column: x => x.MedewerkerId,
                        principalTable: "Medewerkers",
                        principalColumn: "MedewerkerId");
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Voertuigen_VoertuigId",
                        column: x => x.VoertuigId,
                        principalTable: "Voertuigen",
                        principalColumn: "VoertuigId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonnementen_KlantId",
                table: "Abonnementen",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_HuurderId",
                table: "HuurAanvragen",
                column: "HuurderId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_MedewerkerId",
                table: "HuurAanvragen",
                column: "MedewerkerId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_VoertuigId",
                table: "HuurAanvragen",
                column: "VoertuigId");

            migrationBuilder.CreateIndex(
                name: "IX_Medewerkers_AbonnementId",
                table: "Medewerkers",
                column: "AbonnementId");

            migrationBuilder.CreateIndex(
                name: "IX_Schades_VoertuigId",
                table: "Schades",
                column: "VoertuigId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuurAanvragen");

            migrationBuilder.DropTable(
                name: "Schades");

            migrationBuilder.DropTable(
                name: "Huurders");

            migrationBuilder.DropTable(
                name: "Medewerkers");

            migrationBuilder.DropTable(
                name: "Voertuigen");

            migrationBuilder.DropTable(
                name: "Abonnementen");

            migrationBuilder.DropTable(
                name: "Klanten");
        }
    }
}
