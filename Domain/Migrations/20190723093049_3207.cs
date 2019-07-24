using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _3207 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VoucherStatusId",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VoucherStatusId",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
