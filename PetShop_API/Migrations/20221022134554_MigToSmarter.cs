using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop_API.Migrations
{
    public partial class MigToSmarter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParrotProducts_Products_ProductsModelId",
                table: "ParrotProducts");

            migrationBuilder.DropIndex(
                name: "IX_ParrotProducts_ProductsModelId",
                table: "ParrotProducts");

            migrationBuilder.DropColumn(
                name: "ProductsModelId",
                table: "ParrotProducts");

            migrationBuilder.AddColumn<string>(
                name: "Animal",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ParrotProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ParrotProducts_ProductId",
                table: "ParrotProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParrotProducts_Products_ProductId",
                table: "ParrotProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParrotProducts_Products_ProductId",
                table: "ParrotProducts");

            migrationBuilder.DropIndex(
                name: "IX_ParrotProducts_ProductId",
                table: "ParrotProducts");

            migrationBuilder.DropColumn(
                name: "Animal",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ParrotProducts");

            migrationBuilder.AddColumn<int>(
                name: "ProductsModelId",
                table: "ParrotProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParrotProducts_ProductsModelId",
                table: "ParrotProducts",
                column: "ProductsModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParrotProducts_Products_ProductsModelId",
                table: "ParrotProducts",
                column: "ProductsModelId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
