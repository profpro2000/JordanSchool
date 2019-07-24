using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class test21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThisIsId",
                table: "Payments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThisIsId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);
        }
    }
}
