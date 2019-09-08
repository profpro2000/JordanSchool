using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class PaymentChequeV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques");

            migrationBuilder.RenameColumn(
                name: "StudentFeeId",
                table: "Payment_cheques",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_StudentFeeId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Student_fees_PaymentId",
                table: "Payment_cheques",
                column: "PaymentId",
                principalTable: "Student_fees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Student_fees_PaymentId",
                table: "Payment_cheques");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payment_cheques",
                newName: "StudentFeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_PaymentId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_StudentFeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques",
                column: "StudentFeeId",
                principalTable: "Student_fees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
