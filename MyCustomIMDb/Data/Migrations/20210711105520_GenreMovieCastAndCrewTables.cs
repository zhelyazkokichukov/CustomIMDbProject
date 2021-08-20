using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCustomIMDb.Data.Migrations
{
    public partial class GenreMovieCastAndCrewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "MovieCastAndCrew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CastAndCrewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCastAndCrew", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCastAndCrew_CastAndCrew_CastAndCrewId",
                        column: x => x.CastAndCrewId,
                        principalTable: "CastAndCrew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCastAndCrew_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCastAndCrew_CastAndCrewId",
                table: "MovieCastAndCrew",
                column: "CastAndCrewId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCastAndCrew_MovieId",
                table: "MovieCastAndCrew",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "CastAndCrewMovie",
                columns: table => new
                {
                    CastAndCrewId = table.Column<int>(type: "int", nullable: false),
                    FilmographyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastAndCrewMovie", x => new { x.CastAndCrewId, x.FilmographyId });
                    table.ForeignKey(
                        name: "FK_CastAndCrewMovie_CastAndCrew_CastAndCrewId",
                        column: x => x.CastAndCrewId,
                        principalTable: "CastAndCrew",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastAndCrewMovie_Movies_FilmographyId",
                        column: x => x.FilmographyId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastAndCrewMovie_FilmographyId",
                table: "CastAndCrewMovie",
                column: "FilmographyId");
        }
    }
}
