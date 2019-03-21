using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAnnotation.Migrations
{
    public partial class rTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Book",
                nullable: true);
        }
    }
}
