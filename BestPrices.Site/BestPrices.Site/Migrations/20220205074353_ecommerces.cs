using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPrices.Site.Migrations
{
    public partial class ecommerces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sites",
                table: "Sites");

            migrationBuilder.RenameTable(
                name: "Sites",
                newName: "Ecommerces");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ecommerces",
                table: "Ecommerces",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ecommerces",
                table: "Ecommerces");

            migrationBuilder.RenameTable(
                name: "Ecommerces",
                newName: "Sites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sites",
                table: "Sites",
                column: "Id");
        }
    }
}
