using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class NewBuildingNewReviewTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Characters_CharacterID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "CharacterReviews");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "CharacterReviews",
                newName: "IX_CharacterReviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CharacterID",
                table: "CharacterReviews",
                newName: "IX_CharacterReviews_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterReviews",
                table: "CharacterReviews",
                column: "ReviewID");

            migrationBuilder.CreateTable(
                name: "ComicReviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ComicID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicReviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_ComicReviews_Comics_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comics",
                        principalColumn: "ComicID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicReviews_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieReviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_MovieReviews_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieReviews_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComicReviews_ComicID",
                table: "ComicReviews",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicReviews_UserID",
                table: "ComicReviews",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_MovieID",
                table: "MovieReviews",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_UserID",
                table: "MovieReviews",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterReviews_Characters_CharacterID",
                table: "CharacterReviews",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterReviews_Users_UserID",
                table: "CharacterReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Characters_CharacterID",
                table: "CharacterReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Users_UserID",
                table: "CharacterReviews");

            migrationBuilder.DropTable(
                name: "ComicReviews");

            migrationBuilder.DropTable(
                name: "MovieReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterReviews",
                table: "CharacterReviews");

            migrationBuilder.RenameTable(
                name: "CharacterReviews",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterReviews_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterReviews_CharacterID",
                table: "Reviews",
                newName: "IX_Reviews_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Characters_CharacterID",
                table: "Reviews",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
