using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _150711 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CDType",
                table: "Fin_items");

            migrationBuilder.DropColumn(
                name: "VPType",
                table: "Fin_items");

            migrationBuilder.AddColumn<int>(
                name: "cdTypeId",
                table: "Fin_items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vpTypeId",
                table: "Fin_items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fin_items_cdTypeId",
                table: "Fin_items",
                column: "cdTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_items_vpTypeId",
                table: "Fin_items",
                column: "vpTypeId");

           
 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fin_items_Lkp_Lookup_cdTypeId",
                table: "Fin_items");

            migrationBuilder.DropForeignKey(
                name: "FK_Fin_items_Lkp_Lookup_vpTypeId",
                table: "Fin_items");

            migrationBuilder.DropIndex(
                name: "IX_Fin_items_cdTypeId",
                table: "Fin_items");

            migrationBuilder.DropIndex(
                name: "IX_Fin_items_vpTypeId",
                table: "Fin_items");

            migrationBuilder.DropColumn(
                name: "cdTypeId",
                table: "Fin_items");

            migrationBuilder.DropColumn(
                name: "vpTypeId",
                table: "Fin_items");

            migrationBuilder.AddColumn<string>(
                name: "CDType",
                table: "Fin_items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VPType",
                table: "Fin_items",
                nullable: true);
        }
    }
}
