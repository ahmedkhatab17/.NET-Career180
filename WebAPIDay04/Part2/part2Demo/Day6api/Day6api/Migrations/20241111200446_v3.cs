using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day6api.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "hiredate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "teacherid",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hiredate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "teacherid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "title",
                table: "AspNetUsers");
        }
    }
}
