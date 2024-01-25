using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class BuildingNewReviewTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Comics_ComicID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ComicID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_MovieID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ComicID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Reviews");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComicID",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ComicID",
                table: "Reviews",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieID",
                table: "Reviews",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Comics_ComicID",
                table: "Reviews",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieID",
                table: "Reviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
