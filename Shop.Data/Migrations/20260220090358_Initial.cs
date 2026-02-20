using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsBuy = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    ActionTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Shop = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShopItems",
                columns: new[] { "Id", "ActionTo", "IsBuy", "Name", "Price", "Shop" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Apple", 28.899999999999999, "Lidl" },
                    { 2, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Banana", 28.899999999999999, "Lidl" },
                    { 3, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Orange", 28.899999999999999, "Lidl" },
                    { 4, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Milk", 28.899999999999999, "Lidl" },
                    { 5, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Bread", 28.899999999999999, "Lidl" },
                    { 6, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Butter", 28.899999999999999, "Lidl" },
                    { 7, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Cheese", 28.899999999999999, "Lidl" },
                    { 8, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Yogurt", 28.899999999999999, "Lidl" },
                    { 9, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Chicken", 28.899999999999999, "Lidl" },
                    { 10, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Rice", 28.899999999999999, "Lidl" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItems");
        }
    }
}
