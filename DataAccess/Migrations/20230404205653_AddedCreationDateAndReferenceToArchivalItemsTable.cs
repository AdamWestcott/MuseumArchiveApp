using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedCreationDateAndReferenceToArchivalItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArchivalItemCreationDate",
                table: "ArchivalItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ArchivalItemReference",
                table: "ArchivalItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArchivalItemCreationDate",
                table: "ArchivalItems");

            migrationBuilder.DropColumn(
                name: "ArchivalItemReference",
                table: "ArchivalItems");
        }
    }
}
