using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class CharacterReviewCollectionRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CharacterReviews_CharacterID",
                table: "CharacterReviews");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterReviews_CharacterID",
                table: "CharacterReviews",
                column: "CharacterID",
                unique: true,
                filter: "[CharacterID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CharacterReviews_CharacterID",
                table: "CharacterReviews");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterReviews_CharacterID",
                table: "CharacterReviews",
                column: "CharacterID");
        }
    }
}
