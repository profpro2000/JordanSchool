using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class yearonpayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Payments");
        }
    }
}
