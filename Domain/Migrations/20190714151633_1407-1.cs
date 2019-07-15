using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _14071 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idd",
                table: "Class_fees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idd",
                table: "Class_fees");
        }
    }
}
