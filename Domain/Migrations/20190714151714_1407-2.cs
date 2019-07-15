using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _14072 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idd",
                table: "Class_fees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idd",
                table: "Class_fees",
                nullable: false,
                defaultValue: 0);
        }
    }
}
