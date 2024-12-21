using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a1851ff-11b5-470c-8192-f5d128ca1a90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f1243fd-ecca-477e-adbc-da446f36f9d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d430b22-267c-40b1-9bdf-f8ed741e5008", null, "customer", "CUSTOMER" },
                    { "93a13f1f-2563-4a89-942f-34e76f51674a", null, "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d430b22-267c-40b1-9bdf-f8ed741e5008");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a13f1f-2563-4a89-942f-34e76f51674a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a1851ff-11b5-470c-8192-f5d128ca1a90", null, "admin", "ADMIN" },
                    { "3f1243fd-ecca-477e-adbc-da446f36f9d9", null, "customer", "CUSTOMER" }
                });
        }
    }
}
