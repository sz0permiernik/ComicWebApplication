using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class WishlistChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishList_Characters_CharacterID",
                table: "WishList");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_Comics_ComicID",
                table: "WishList");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_Movies_MovieID",
                table: "WishList");

            migrationBuilder.DropForeignKey(
                name: "FK_WishList_Users_UserID",
                table: "WishList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishList",
                table: "WishList");

            migrationBuilder.RenameTable(
                name: "WishList",
                newName: "WishLists");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_UserID",
                table: "WishLists",
                newName: "IX_WishLists_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_MovieID",
                table: "WishLists",
                newName: "IX_WishLists_MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_ComicID",
                table: "WishLists",
                newName: "IX_WishLists_ComicID");

            migrationBuilder.RenameIndex(
                name: "IX_WishList_CharacterID",
                table: "WishLists",
                newName: "IX_WishLists_CharacterID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "WishLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists",
                column: "ReviewID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishLists",
                table: "WishLists");

            migrationBuilder.RenameTable(
                name: "WishLists",
                newName: "WishList");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_UserID",
                table: "WishList",
                newName: "IX_WishList_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_MovieID",
                table: "WishList",
                newName: "IX_WishList_MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ComicID",
                table: "WishList",
                newName: "IX_WishList_ComicID");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_CharacterID",
                table: "WishList",
                newName: "IX_WishList_CharacterID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "WishList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishList",
                table: "WishList",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_Characters_CharacterID",
                table: "WishList",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "CharacterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_Comics_ComicID",
                table: "WishList",
                column: "ComicID",
                principalTable: "Comics",
                principalColumn: "ComicID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_Movies_MovieID",
                table: "WishList",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishList_Users_UserID",
                table: "WishList",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
