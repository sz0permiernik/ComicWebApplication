using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddingCharacterMovieComicForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "Movies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Comics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "Comics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CharacterID",
                table: "Movies",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ComicID",
                table: "Movies",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_CharacterID",
                table: "Comics",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_Comics_MovieID",
                table: "Comics",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ComicID",
                table: "Characters",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_MovieID",
                table: "Characters",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Comics_ComicID",
                table: "Characters",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Movies_MovieID",
                table: "Characters",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comics_Characters_CharacterID",
                table: "Comics",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comics_Movies_MovieID",
                table: "Comics",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Characters_CharacterID",
                table: "Movies",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Comics_ComicID",
                table: "Movies",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Comics_ComicID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Movies_MovieID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Comics_Characters_CharacterID",
                table: "Comics");

            migrationBuilder.DropForeignKey(
                name: "FK_Comics_Movies_MovieID",
                table: "Comics");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Characters_CharacterID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Comics_ComicID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CharacterID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ComicID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Comics_CharacterID",
                table: "Comics");

            migrationBuilder.DropIndex(
                name: "IX_Comics_MovieID",
                table: "Comics");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ComicID",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_MovieID",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Comics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "Comics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
