using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAppCRUD.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lasttname",
                table: "Employees",
                newName: "Lastname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Employees",
                newName: "Lasttname");
        }
    }
}
