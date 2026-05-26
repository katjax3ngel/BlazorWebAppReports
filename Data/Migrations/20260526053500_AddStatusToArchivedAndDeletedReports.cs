using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppReports.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToArchivedAndDeletedReports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "DeletedReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ArchivedReports",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "DeletedReports");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ArchivedReports");
        }
    }
}
