using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedCollectionIDandIsPartOfACollectionToArchivalItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CollectionId",
                table: "ArchivalItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPartOfACollection",
                table: "ArchivalItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "ArchivalItems");

            migrationBuilder.DropColumn(
                name: "IsPartOfACollection",
                table: "ArchivalItems");
        }
    }
}
