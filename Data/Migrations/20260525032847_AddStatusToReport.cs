using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppReports.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Report",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Report");
        }
    }
}
