using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class lkpV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Lkp_Brothers_Discount_Rate",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BrotherSeq",
                table: "Lkp_Brothers_Discount_Rate",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Lkp_Brothers_Discount_Rate",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrotherSeq",
                table: "Lkp_Brothers_Discount_Rate",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
