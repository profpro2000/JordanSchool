using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class StudentFeesUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques");

            migrationBuilder.AlterColumn<int>(
                name: "StudentFeeId",
                table: "Payment_cheques",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques",
                column: "StudentFeeId",
                principalTable: "Student_fees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques");

            migrationBuilder.AlterColumn<int>(
                name: "StudentFeeId",
                table: "Payment_cheques",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques",
                column: "StudentFeeId",
                principalTable: "Student_fees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
