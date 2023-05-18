using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class RemovedItemsFromProvidenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvidenceDateOfPurchase",
                table: "Providences");

            migrationBuilder.DropColumn(
                name: "ProvidenceImage",
                table: "Providences");

            migrationBuilder.DropColumn(
                name: "PurchaseValue",
                table: "Providences");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ProvidenceDateOfPurchase",
                table: "Providences",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "ProvidenceImage",
                table: "Providences",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<double>(
                name: "PurchaseValue",
                table: "Providences",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
