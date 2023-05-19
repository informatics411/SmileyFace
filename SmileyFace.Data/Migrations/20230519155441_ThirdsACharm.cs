using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmileyFace.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdsACharm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clusters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmojiId = table.Column<int>(type: "int", nullable: false),
                    EmojiString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmojiInstanceLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clusters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmoji = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_SessionProfiles_SessionProfileId",
                        column: x => x.SessionProfileId,
                        principalTable: "SessionProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emojis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmojiUnicode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmojiMeaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmojiGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmojiLocation = table.Column<int>(type: "int", nullable: false),
                    NextEmoji = table.Column<int>(type: "int", nullable: false),
                    EmojiRank = table.Column<int>(type: "int", nullable: false),
                    GameProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emojis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emojis_Game_GameProfileId",
                        column: x => x.GameProfileId,
                        principalTable: "Game",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emojis_GameProfileId",
                table: "Emojis",
                column: "GameProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_SessionProfileId",
                table: "Game",
                column: "SessionProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clusters");

            migrationBuilder.DropTable(
                name: "Emojis");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "SessionProfiles");
        }
    }
}
