using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreationOfKeywordTagGroupsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeywordTagGroups",
                columns: table => new
                {
                    keywordTagGroupID = table.Column<string>(type: "TEXT", nullable: false),
                    keywordTagID = table.Column<string>(type: "TEXT", nullable: false),
                    ArchivalItemID = table.Column<string>(type: "TEXT", nullable: false),
                    keywordTagName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordTagGroups", x => x.keywordTagGroupID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeywordTagGroups");
        }
    }
}
