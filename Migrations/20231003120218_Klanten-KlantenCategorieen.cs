using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WerkenMetData.Migrations
{
    /// <inheritdoc />
    public partial class KlantenKlantenCategorieen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Klanten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Klanten_CategorieId",
                table: "Klanten",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Klanten_KlantenCategorieen_CategorieId",
                table: "Klanten",
                column: "CategorieId",
                principalTable: "KlantenCategorieen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Klanten_KlantenCategorieen_CategorieId",
                table: "Klanten");

            migrationBuilder.DropIndex(
                name: "IX_Klanten_CategorieId",
                table: "Klanten");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Klanten");
        }
    }
}
