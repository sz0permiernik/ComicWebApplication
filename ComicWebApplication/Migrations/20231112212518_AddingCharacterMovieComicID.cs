using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddingCharacterMovieComicID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComicID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterID",
                table: "Comics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Comics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComicID",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ComicID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CharacterID",
                table: "Comics");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Comics");

            migrationBuilder.DropColumn(
                name: "ComicID",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Characters");
        }
    }
}
