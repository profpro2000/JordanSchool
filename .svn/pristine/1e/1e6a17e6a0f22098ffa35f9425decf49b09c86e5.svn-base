using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class finV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinItemOrder",
                table: "Student_fees");

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

            migrationBuilder.AddColumn<int>(
                name: "FinItemOrder",
                table: "Student_fees",
                nullable: true);
        }
    }
}
