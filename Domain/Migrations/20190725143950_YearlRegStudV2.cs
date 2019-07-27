using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class YearlRegStudV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudStatusId",
                table: "Reg_StudYearly",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_StudStatusId",
                table: "Reg_StudYearly",
                column: "StudStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reg_StudYearly_Lkp_Lookup_StudStatusId",
                table: "Reg_StudYearly",
                column: "StudStatusId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reg_StudYearly_Lkp_Lookup_StudStatusId",
                table: "Reg_StudYearly");

            migrationBuilder.DropIndex(
                name: "IX_Reg_StudYearly_StudStatusId",
                table: "Reg_StudYearly");

            migrationBuilder.DropColumn(
                name: "StudStatusId",
                table: "Reg_StudYearly");
        }
    }
}
