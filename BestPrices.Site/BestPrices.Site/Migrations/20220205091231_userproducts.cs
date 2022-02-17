using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPrices.Site.Migrations
{
    public partial class userproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Products");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UsersProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "UsersProducts");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
