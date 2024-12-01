using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDay2.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "dept_id", "fullname", "hiredate", "password", "netsalary", "username" },
                values: new object[,]
                {
                    { 1, 1, "mostafa mohamed", new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 12000m, "mostafa" },
                    { 2, 1, "ola ahmed", new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 12000m, "ola" },
                    { 3, 2, "ali ahmed", new DateTime(2005, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 12000m, "ali" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
