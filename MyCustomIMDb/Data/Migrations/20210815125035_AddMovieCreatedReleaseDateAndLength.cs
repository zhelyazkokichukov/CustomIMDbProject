using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCustomIMDb.Data.Migrations
{
    public partial class AddMovieCreatedReleaseDateAndLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReleaseDate",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");
        }
    }
}
