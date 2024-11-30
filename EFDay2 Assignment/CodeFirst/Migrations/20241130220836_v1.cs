using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bref = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CataId = table.Column<int>(type: "int", nullable: true),
                    AuthId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Author_AuthId",
                        column: x => x.AuthId,
                        principalTable: "Author",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_Catalog_CataId",
                        column: x => x.CataId,
                        principalTable: "Catalog",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthId",
                table: "News",
                column: "AuthId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CataId",
                table: "News",
                column: "CataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Catalog");
        }
    }
}
