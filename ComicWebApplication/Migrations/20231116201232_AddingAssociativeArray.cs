using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddingAssociativeArray : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterComics",
                columns: table => new
                {
                    CharacterComicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    ComicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterComics", x => x.CharacterComicID);
                    table.ForeignKey(
                        name: "FK_CharacterComics_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterComics_Comics_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comics",
                        principalColumn: "ComicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMovies",
                columns: table => new
                {
                    CharacterMovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovies", x => x.CharacterMovieID);
                    table.ForeignKey(
                        name: "FK_CharacterMovies_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovies_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWorlds",
                columns: table => new
                {
                    CharacterWorldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    WorldID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWorlds", x => x.CharacterWorldID);
                    table.ForeignKey(
                        name: "FK_CharacterWorlds_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWorlds_Worlds_WorldID",
                        column: x => x.WorldID,
                        principalTable: "Worlds",
                        principalColumn: "WorldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicMovies",
                columns: table => new
                {
                    ComicMovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicID = table.Column<int>(type: "int", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicMovies", x => x.ComicMovieID);
                    table.ForeignKey(
                        name: "FK_ComicMovies_Comics_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comics",
                        principalColumn: "ComicID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicMovies_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicWorlds",
                columns: table => new
                {
                    ComicWorldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicID = table.Column<int>(type: "int", nullable: false),
                    WorldID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicWorlds", x => x.ComicWorldID);
                    table.ForeignKey(
                        name: "FK_ComicWorlds_Comics_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comics",
                        principalColumn: "ComicID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicWorlds_Worlds_WorldID",
                        column: x => x.WorldID,
                        principalTable: "Worlds",
                        principalColumn: "WorldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieWorlds",
                columns: table => new
                {
                    MovieWorldID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    WorldID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieWorlds", x => x.MovieWorldID);
                    table.ForeignKey(
                        name: "FK_MovieWorlds_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieWorlds_Worlds_WorldID",
                        column: x => x.WorldID,
                        principalTable: "Worlds",
                        principalColumn: "WorldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterComics_CharacterID",
                table: "CharacterComics",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterComics_ComicID",
                table: "CharacterComics",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovies_CharacterID",
                table: "CharacterMovies",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovies_MovieID",
                table: "CharacterMovies",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWorlds_CharacterID",
                table: "CharacterWorlds",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWorlds_WorldID",
                table: "CharacterWorlds",
                column: "WorldID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicMovies_ComicID",
                table: "ComicMovies",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicMovies_MovieID",
                table: "ComicMovies",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicWorlds_ComicID",
                table: "ComicWorlds",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicWorlds_WorldID",
                table: "ComicWorlds",
                column: "WorldID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieWorlds_MovieID",
                table: "MovieWorlds",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieWorlds_WorldID",
                table: "MovieWorlds",
                column: "WorldID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterComics");

            migrationBuilder.DropTable(
                name: "CharacterMovies");

            migrationBuilder.DropTable(
                name: "CharacterWorlds");

            migrationBuilder.DropTable(
                name: "ComicMovies");

            migrationBuilder.DropTable(
                name: "ComicWorlds");

            migrationBuilder.DropTable(
                name: "MovieWorlds");
        }
    }
}
