using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicsAndAllProject.Plugins.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class FixIssueEntityTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "Issues");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Issues",
                newName: "SourceUrl");

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "IssueOrder",
                table: "Issues",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "IssueOrder",
                table: "Issues");

            migrationBuilder.RenameColumn(
                name: "SourceUrl",
                table: "Issues",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
