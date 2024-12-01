using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay2.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentdeptid",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "departmentdeptid",
                table: "Employees",
                newName: "dept_id");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_departmentdeptid",
                table: "Employees",
                newName: "IX_Employees_dept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_dept_id",
                table: "Employees",
                column: "dept_id",
                principalTable: "Departments",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_dept_id",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "dept_id",
                table: "Employees",
                newName: "departmentdeptid");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_dept_id",
                table: "Employees",
                newName: "IX_Employees_departmentdeptid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentdeptid",
                table: "Employees",
                column: "departmentdeptid",
                principalTable: "Departments",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
