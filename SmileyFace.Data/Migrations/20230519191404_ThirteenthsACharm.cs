using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmileyFace.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirteenthsACharm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emojis_Game_GameProfileId",
                table: "Emojis");

            migrationBuilder.DropTable(
                name: "Clusters");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Emojis_GameProfileId",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "GameProfileId",
                table: "Emojis");

            migrationBuilder.RenameColumn(
                name: "NextEmoji",
                table: "Emojis",
                newName: "IsGuardian");

            migrationBuilder.RenameColumn(
                name: "EmojiUnicode",
                table: "Emojis",
                newName: "Unicode");

            migrationBuilder.RenameColumn(
                name: "EmojiMeaning",
                table: "Emojis",
                newName: "Meaning");

            migrationBuilder.RenameColumn(
                name: "EmojiGenre",
                table: "Emojis",
                newName: "Genre");

            migrationBuilder.AddColumn<string>(
                name: "Alt1Meaning",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alt2Meaning",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alt3Meaning",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alt4Meaning",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Alt5Meaning",
                table: "Emojis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GuardianAt",
                table: "Emojis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsNested",
                table: "Emojis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "IdeaMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdeaMaps_SessionProfiles_SessionProfileId",
                        column: x => x.SessionProfileId,
                        principalTable: "SessionProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdeaChains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmojiId = table.Column<int>(type: "int", nullable: false),
                    EmojiString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmojiInstanceLocation = table.Column<int>(type: "int", nullable: false),
                    IdeaMapProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaChains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdeaChains_IdeaMaps_IdeaMapProfileId",
                        column: x => x.IdeaMapProfileId,
                        principalTable: "IdeaMaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdeaChains_IdeaMapProfileId",
                table: "IdeaChains",
                column: "IdeaMapProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaMaps_SessionProfileId",
                table: "IdeaMaps",
                column: "SessionProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdeaChains");

            migrationBuilder.DropTable(
                name: "IdeaMaps");

            migrationBuilder.DropColumn(
                name: "Alt1Meaning",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "Alt2Meaning",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "Alt3Meaning",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "Alt4Meaning",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "Alt5Meaning",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "GuardianAt",
                table: "Emojis");

            migrationBuilder.DropColumn(
                name: "IsNested",
                table: "Emojis");

            migrationBuilder.RenameColumn(
                name: "Unicode",
                table: "Emojis",
                newName: "EmojiUnicode");

            migrationBuilder.RenameColumn(
                name: "Meaning",
                table: "Emojis",
                newName: "EmojiMeaning");

            migrationBuilder.RenameColumn(
                name: "IsGuardian",
                table: "Emojis",
                newName: "NextEmoji");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Emojis",
                newName: "EmojiGenre");

            migrationBuilder.AddColumn<int>(
                name: "GameProfileId",
                table: "Emojis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clusters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmojiId = table.Column<int>(type: "int", nullable: false),
                    EmojiInstanceLocation = table.Column<int>(type: "int", nullable: false),
                    EmojiString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clusters", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Emojis_GameProfileId",
                table: "Emojis",
                column: "GameProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_SessionProfileId",
                table: "Game",
                column: "SessionProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emojis_Game_GameProfileId",
                table: "Emojis",
                column: "GameProfileId",
                principalTable: "Game",
                principalColumn: "Id");
        }
    }
}
