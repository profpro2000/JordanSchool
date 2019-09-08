using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class studFeesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Student_fees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_ParentId",
                table: "Student_fees",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Reg_Parent_ParentId",
                table: "Student_fees",
                column: "ParentId",
                principalTable: "Reg_Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Reg_Parent_ParentId",
                table: "Student_fees");

            migrationBuilder.DropIndex(
                name: "IX_Student_fees_ParentId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Student_fees");
        }
    }
}
