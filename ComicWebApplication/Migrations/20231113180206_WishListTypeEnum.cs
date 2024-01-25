using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class WishListTypeEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Characters_CharacterID",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Comics_ComicID",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Movies_MovieID",
                table: "WishLists");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Users_UserID",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_WishLists_CharacterID",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_WishLists_ComicID",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_WishLists_MovieID",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "CharacterID",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "ComicID",
                table: "WishLists");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "WishLists",
                newName: "WishListType");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "WishLists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Users_UserID",
                table: "WishLists",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Users_UserID",
                table: "WishLists");

            migrationBuilder.RenameColumn(
                name: "WishListType",
                table: "WishLists",
                newName: "MovieID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "WishLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CharacterID",
                table: "WishLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComicID",
                table: "WishLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CharacterID",
                table: "WishLists",
                column: "CharacterID");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ComicID",
                table: "WishLists",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_MovieID",
                table: "WishLists",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Characters_CharacterID",
                table: "WishLists",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Comics_ComicID",
                table: "WishLists",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Movies_MovieID",
                table: "WishLists",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Users_UserID",
                table: "WishLists",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
