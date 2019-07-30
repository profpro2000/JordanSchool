using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class yearonpayment1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Payments_YearId",
                table: "Payments",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments",
                column: "YearId",
                principalTable: "Lkp_Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_YearId",
                table: "Payments");
        }
    }
}
