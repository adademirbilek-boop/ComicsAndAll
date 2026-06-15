using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComicsAndAllProject.Plugins.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class FixIssueEntityTypes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "Issues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "Issues");
        }
    }
}
