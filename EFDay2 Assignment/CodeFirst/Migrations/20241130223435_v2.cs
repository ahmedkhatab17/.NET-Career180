using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Bref", "JoinDate", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "Health Specialist", new DateTime(2024, 12, 1, 0, 34, 34, 698, DateTimeKind.Local).AddTicks(635), "Ahmed Khattab", "pass123", "ahmed_khatab" },
                    { 2, "Technology Enthusiast", new DateTime(2024, 12, 1, 0, 34, 34, 698, DateTimeKind.Local).AddTicks(1695), "Omar Khatab", "pass123", "omar_khatab" },
                    { 3, "Business Consultant", new DateTime(2024, 12, 1, 0, 34, 34, 698, DateTimeKind.Local).AddTicks(1709), "Sara Ali", "pass123", "sara_ali" }
                });

            migrationBuilder.InsertData(
                table: "Catalog",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Latest in technology and innovations", "Technology" },
                    { 2, "Health and wellness tips", "Health" },
                    { 3, "Latest trends in business and economy", "Business" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthId", "Bref", "CataId", "DateTime", "Desc", "Title" },
                values: new object[,]
                {
                    { 1, 2, "How AI is reshaping industries", 1, new DateTime(2024, 12, 1, 0, 34, 34, 694, DateTimeKind.Local).AddTicks(9450), "A deep dive into the advancements of Artificial Intelligence and its impact on the world.", "AI Revolution" },
                    { 2, 1, "Your guide to a healthier lifestyle", 2, new DateTime(2024, 12, 1, 0, 34, 34, 697, DateTimeKind.Local).AddTicks(2101), "Discover essential tips and tricks to improve your health and well-being.", "Healthy Living Tips" },
                    { 3, 3, "Key factors driving global economic growth", 3, new DateTime(2024, 12, 1, 0, 34, 34, 697, DateTimeKind.Local).AddTicks(2132), "An analysis of the factors shaping the global economy in the coming year.", "Economic Growth in 2024" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catalog",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
