using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LKPYearV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Active",
                table: "Lkp_Year",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Active",
                table: "Lkp_Year",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
