using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmileyFace.Data.Migrations
{
    /// <inheritdoc />
    public partial class FourteenthsACharm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuardianAt",
                table: "Emojis",
                newName: "IsDirected");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDirected",
                table: "Emojis",
                newName: "GuardianAt");
        }
    }
}
