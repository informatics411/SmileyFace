using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmileyFace.Data.Migrations
{
    /// <inheritdoc />
    public partial class FifteenthsACharm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDirected",
                table: "Emojis",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "EmojiLocation",
                table: "Emojis",
                newName: "Direction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Emojis",
                newName: "IsDirected");

            migrationBuilder.RenameColumn(
                name: "Direction",
                table: "Emojis",
                newName: "EmojiLocation");
        }
    }
}
