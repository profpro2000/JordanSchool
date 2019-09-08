using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class PaymentChequeV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Student_fees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Student_fees");
        }
    }
}
