using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class yaseenV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinItemOrder",
                table: "Fin_items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinItemOrder",
                table: "Fin_items");
        }
    }
}
