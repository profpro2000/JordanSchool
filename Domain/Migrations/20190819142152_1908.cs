using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _1908 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentCheques_Lkp_Lookup_BankId",
                table: "PaymentCheques");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentCheques_Payments_PaymentId",
                table: "PaymentCheques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentCheques",
                table: "PaymentCheques");

            migrationBuilder.RenameTable(
                name: "PaymentCheques",
                newName: "Payment_cheques");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentCheques_PaymentId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentCheques_BankId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment_cheques",
                table: "Payment_cheques",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Lkp_Lookup_BankId",
                table: "Payment_cheques",
                column: "BankId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Payments_PaymentId",
                table: "Payment_cheques",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Lkp_Lookup_BankId",
                table: "Payment_cheques");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Payments_PaymentId",
                table: "Payment_cheques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment_cheques",
                table: "Payment_cheques");

            migrationBuilder.RenameTable(
                name: "Payment_cheques",
                newName: "PaymentCheques");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_PaymentId",
                table: "PaymentCheques",
                newName: "IX_PaymentCheques_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_BankId",
                table: "PaymentCheques",
                newName: "IX_PaymentCheques_BankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentCheques",
                table: "PaymentCheques",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentCheques_Lkp_Lookup_BankId",
                table: "PaymentCheques",
                column: "BankId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentCheques_Payments_PaymentId",
                table: "PaymentCheques",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
