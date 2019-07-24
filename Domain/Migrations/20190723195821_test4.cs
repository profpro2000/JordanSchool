using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThisIsId",
                table: "Payments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             
        }
    }
}
