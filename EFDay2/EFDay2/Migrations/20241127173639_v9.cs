using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay2.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "departmentdeptid",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentdeptid",
                table: "Employees",
                column: "departmentdeptid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentdeptid",
                table: "Employees",
                column: "departmentdeptid",
                principalTable: "Departments",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentdeptid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentdeptid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "departmentdeptid",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Departments",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}
