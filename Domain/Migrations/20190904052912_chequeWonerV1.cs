using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class chequeWonerV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChequeWoner",
                table: "Payment_cheques",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChequeWoner",
                table: "Payment_cheques");
        }
    }
}
