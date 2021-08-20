using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCustomIMDb.Data.Migrations
{
    public partial class AddMovieCreatedStoryline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Storyline",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Storyline",
                table: "Movies");
        }
    }
}
