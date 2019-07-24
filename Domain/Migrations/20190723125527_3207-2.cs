using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _32072 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegParentId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RegParentId",
                table: "Payments",
                column: "RegParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Reg_Parent_RegParentId",
                table: "Payments",
                column: "RegParentId",
                principalTable: "Reg_Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Reg_Parent_RegParentId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_RegParentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "RegParentId",
                table: "Payments");
        }
    }
}
