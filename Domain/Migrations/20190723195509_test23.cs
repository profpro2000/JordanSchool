using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class test23 : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThisIsId",
                table: "Payments");
        }
    }
}
