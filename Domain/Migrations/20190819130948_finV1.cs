using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class finV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinItemOrder",
                table: "Student_fees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinItemOrder",
                table: "Student_fees");
        }
    }
}
