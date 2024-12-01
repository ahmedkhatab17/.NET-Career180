using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay2.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "netalary",
                table: "Employees",
                newName: "netsalary");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "netsalary",
                table: "Employees",
                newName: "netalary");
        }
    }
}
