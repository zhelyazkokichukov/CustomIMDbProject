using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCustomIMDb.Data.Migrations
{
    public partial class TVShowEpisodeTvShowCastAndCrewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "MovieRatings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TVShowId",
                table: "MovieRatings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EpisodeId",
                table: "CastAndCrew",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TVShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PlotSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storyline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PlotSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TVShowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_TVShows_TVShowId",
                        column: x => x.TVShowId,
                        principalTable: "TVShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TVShowCastAndCrew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TVShowId = table.Column<int>(type: "int", nullable: false),
                    CastAndCrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShowCastAndCrew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TVShowCastAndCrew_CastAndCrew_CastAndCrewId",
                        column: x => x.CastAndCrewId,
                        principalTable: "CastAndCrew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TVShowCastAndCrew_TVShows_TVShowId",
                        column: x => x.TVShowId,
                        principalTable: "TVShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_EpisodeId",
                table: "MovieRatings",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieRatings_TVShowId",
                table: "MovieRatings",
                column: "TVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_CastAndCrew_EpisodeId",
                table: "CastAndCrew",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_TVShowId",
                table: "Episodes",
                column: "TVShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TVShowCastAndCrew_CastAndCrewId",
                table: "TVShowCastAndCrew",
                column: "CastAndCrewId");

            migrationBuilder.CreateIndex(
                name: "IX_TVShowCastAndCrew_TVShowId",
                table: "TVShowCastAndCrew",
                column: "TVShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_CastAndCrew_Episodes_EpisodeId",
                table: "CastAndCrew",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_Episodes_EpisodeId",
                table: "MovieRatings",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_TVShows_TVShowId",
                table: "MovieRatings",
                column: "TVShowId",
                principalTable: "TVShows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CastAndCrew_Episodes_EpisodeId",
                table: "CastAndCrew");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_Episodes_EpisodeId",
                table: "MovieRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_TVShows_TVShowId",
                table: "MovieRatings");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "TVShowCastAndCrew");

            migrationBuilder.DropTable(
                name: "TVShows");

            migrationBuilder.DropIndex(
                name: "IX_MovieRatings_EpisodeId",
                table: "MovieRatings");

            migrationBuilder.DropIndex(
                name: "IX_MovieRatings_TVShowId",
                table: "MovieRatings");

            migrationBuilder.DropIndex(
                name: "IX_CastAndCrew_EpisodeId",
                table: "CastAndCrew");

            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "MovieRatings");

            migrationBuilder.DropColumn(
                name: "TVShowId",
                table: "MovieRatings");

            migrationBuilder.DropColumn(
                name: "EpisodeId",
                table: "CastAndCrew");
        }
    }
}
