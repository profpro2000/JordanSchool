using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateLKPClassV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClassSeq",
                table: "Lkp_Class",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ClassSeq",
                table: "Lkp_Class",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
