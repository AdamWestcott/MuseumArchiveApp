using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreationOfProvenanceRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProvenanceRecords",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ProvidenceID = table.Column<string>(type: "TEXT", nullable: false),
                    ProvenanceRecordImage = table.Column<byte[]>(type: "BLOB", nullable: false),
                    ProvenanceName = table.Column<string>(type: "TEXT", nullable: false),
                    ProvenanceLocationOfPurchase = table.Column<string>(type: "TEXT", nullable: false),
                    ProvenanceNotes = table.Column<string>(type: "TEXT", nullable: false),
                    ProvenanceDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ProvenanceNumberOfPriorOwners = table.Column<int>(type: "INTEGER", nullable: false),
                    ProvenanceDateOfPurchase = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PurchaseValue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvenanceRecords", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProvenanceRecords");
        }
    }
}
