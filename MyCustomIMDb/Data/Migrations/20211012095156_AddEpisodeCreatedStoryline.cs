using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCustomIMDb.Data.Migrations
{
    public partial class AddEpisodeCreatedStoryline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Episodes",
                newName: "Storyline");

            migrationBuilder.AddColumn<string>(
                name: "EpisodeAiredDate",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpisodeAiredDate",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "Storyline",
                table: "Episodes",
                newName: "ReleaseDate");
        }
    }
}
