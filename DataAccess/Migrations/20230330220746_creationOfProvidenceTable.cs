using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class creationOfProvidenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providences",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ArchivalItemID = table.Column<string>(type: "TEXT", nullable: false),
                    ProvidenceImage = table.Column<byte[]>(type: "BLOB", nullable: false),
                    ProvidenceName = table.Column<string>(type: "TEXT", nullable: false),
                    ProvidenceDateOfPurchase = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PurchaseValue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providences");
        }
    }
}
