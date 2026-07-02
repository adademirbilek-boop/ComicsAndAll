using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicsAndAllProject.Plugins.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoriteCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCharacters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issues_SeriesId",
                table: "Issues",
                column: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Series_SeriesId",
                table: "Issues",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Series_SeriesId",
                table: "Issues");

            migrationBuilder.DropTable(
                name: "FavoriteCharacters");

            migrationBuilder.DropIndex(
                name: "IX_Issues_SeriesId",
                table: "Issues");
        }
    }
}
