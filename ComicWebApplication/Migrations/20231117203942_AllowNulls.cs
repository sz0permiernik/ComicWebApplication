using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class AllowNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserID",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterComics_Characters_CharacterID",
                table: "CharacterComics");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterComics_Comics_ComicID",
                table: "CharacterComics");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMovies_Characters_CharacterID",
                table: "CharacterMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMovies_Movies_MovieID",
                table: "CharacterMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Characters_CharacterID",
                table: "CharacterReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Users_UserID",
                table: "CharacterReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWorlds_Characters_CharacterID",
                table: "CharacterWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWorlds_Worlds_WorldID",
                table: "CharacterWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicMovies_Comics_ComicID",
                table: "ComicMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicMovies_Movies_MovieID",
                table: "ComicMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicReviews_Comics_ComicID",
                table: "ComicReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicReviews_Users_UserID",
                table: "ComicReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicWorlds_Comics_ComicID",
                table: "ComicWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicWorlds_Worlds_WorldID",
                table: "ComicWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Movies_MovieID",
                table: "MovieReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Users_UserID",
                table: "MovieReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWorlds_Movies_MovieID",
                table: "MovieWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWorlds_Worlds_WorldID",
                table: "MovieWorlds");

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "MovieWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "MovieWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "MovieReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "MovieReviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "MovieReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "ComicWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "ComicReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "ComicReviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "ComicMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "CharacterWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterWorlds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "CharacterReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "CharacterReviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "CharacterMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "CharacterComics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterComics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Achievements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Users_UserID",
                table: "Achievements",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterComics_Characters_CharacterID",
                table: "CharacterComics",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterComics_Comics_ComicID",
                table: "CharacterComics",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMovies_Characters_CharacterID",
                table: "CharacterMovies",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMovies_Movies_MovieID",
                table: "CharacterMovies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterReviews_Characters_CharacterID",
                table: "CharacterReviews",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterReviews_Users_UserID",
                table: "CharacterReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWorlds_Characters_CharacterID",
                table: "CharacterWorlds",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWorlds_Worlds_WorldID",
                table: "CharacterWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicMovies_Comics_ComicID",
                table: "ComicMovies",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicMovies_Movies_MovieID",
                table: "ComicMovies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicReviews_Comics_ComicID",
                table: "ComicReviews",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicReviews_Users_UserID",
                table: "ComicReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicWorlds_Comics_ComicID",
                table: "ComicWorlds",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_ComicWorlds_Worlds_WorldID",
                table: "ComicWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Movies_MovieID",
                table: "MovieReviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Users_UserID",
                table: "MovieReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWorlds_Movies_MovieID",
                table: "MovieWorlds",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWorlds_Worlds_WorldID",
                table: "MovieWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserID",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterComics_Characters_CharacterID",
                table: "CharacterComics");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterComics_Comics_ComicID",
                table: "CharacterComics");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMovies_Characters_CharacterID",
                table: "CharacterMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMovies_Movies_MovieID",
                table: "CharacterMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Characters_CharacterID",
                table: "CharacterReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterReviews_Users_UserID",
                table: "CharacterReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWorlds_Characters_CharacterID",
                table: "CharacterWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWorlds_Worlds_WorldID",
                table: "CharacterWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicMovies_Comics_ComicID",
                table: "ComicMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicMovies_Movies_MovieID",
                table: "ComicMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicReviews_Comics_ComicID",
                table: "ComicReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicReviews_Users_UserID",
                table: "ComicReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicWorlds_Comics_ComicID",
                table: "ComicWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_ComicWorlds_Worlds_WorldID",
                table: "ComicWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Movies_MovieID",
                table: "MovieReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Users_UserID",
                table: "MovieReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWorlds_Movies_MovieID",
                table: "MovieWorlds");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieWorlds_Worlds_WorldID",
                table: "MovieWorlds");

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "MovieWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "MovieWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "MovieReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "MovieReviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "MovieReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "ComicWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "ComicReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "ComicReviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "ComicMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "ComicMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorldID",
                table: "CharacterWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterWorlds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "CharacterReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "CharacterReviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "CharacterMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComicID",
                table: "CharacterComics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterID",
                table: "CharacterComics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Achievements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Users_UserID",
                table: "Achievements",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterComics_Characters_CharacterID",
                table: "CharacterComics",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterComics_Comics_ComicID",
                table: "CharacterComics",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMovies_Characters_CharacterID",
                table: "CharacterMovies",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMovies_Movies_MovieID",
                table: "CharacterMovies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWorlds_Characters_CharacterID",
                table: "CharacterWorlds",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWorlds_Worlds_WorldID",
                table: "CharacterWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicMovies_Comics_ComicID",
                table: "ComicMovies",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicMovies_Movies_MovieID",
                table: "ComicMovies",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicReviews_Comics_ComicID",
                table: "ComicReviews",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicReviews_Users_UserID",
                table: "ComicReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicWorlds_Comics_ComicID",
                table: "ComicWorlds",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComicWorlds_Worlds_WorldID",
                table: "ComicWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Movies_MovieID",
                table: "MovieReviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Users_UserID",
                table: "MovieReviews",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWorlds_Movies_MovieID",
                table: "MovieWorlds",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieWorlds_Worlds_WorldID",
                table: "MovieWorlds",
                column: "WorldID",
                principalTable: "Worlds",
                principalColumn: "WorldID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
