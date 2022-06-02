using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCatalogMusic.Data.Migrations
{
    public partial class AddSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Songs");
        }
    }
}
