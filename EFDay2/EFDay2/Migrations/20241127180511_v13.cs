using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDay2.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.CreateTable(
                name: "Worksfor",
                columns: table => new
                {
                    emp_id = table.Column<int>(type: "int", nullable: false),
                    proj_id = table.Column<int>(type: "int", nullable: false),
                    workingdays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worksfor", x => new { x.emp_id, x.proj_id });
                    table.ForeignKey(
                        name: "FK_Worksfor_Employees_emp_id",
                        column: x => x.emp_id,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Worksfor_Projects_proj_id",
                        column: x => x.proj_id,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Worksfor_proj_id",
                table: "Worksfor",
                column: "proj_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Worksfor");

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    Employeesid = table.Column<int>(type: "int", nullable: false),
                    Projectsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.Employeesid, x.Projectsid });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employees_Employeesid",
                        column: x => x.Employeesid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Projects_Projectsid",
                        column: x => x.Projectsid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_Projectsid",
                table: "EmployeeProject",
                column: "Projectsid");
        }
    }
}
