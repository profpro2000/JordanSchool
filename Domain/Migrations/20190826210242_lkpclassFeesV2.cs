using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class lkpclassFeesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YearId",
                table: "Lkp_Class",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YearId",
                table: "Lkp_Class",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
