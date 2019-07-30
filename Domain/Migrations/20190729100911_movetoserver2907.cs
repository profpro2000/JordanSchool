using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class movetoserver2907 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DescountValue",
                table: "Reg_StudYearly",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DescountValue",
                table: "Reg_StudYearly",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
