using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewBee.Data.Migrations
{
    public partial class DeckCardRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "Flashcard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flashcard_DeckId",
                table: "Flashcard",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flashcard_Deck_DeckId",
                table: "Flashcard",
                column: "DeckId",
                principalTable: "Deck",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flashcard_Deck_DeckId",
                table: "Flashcard");

            migrationBuilder.DropIndex(
                name: "IX_Flashcard_DeckId",
                table: "Flashcard");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "Flashcard");
        }
    }
}
