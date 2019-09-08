using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class izzV123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Payments_PaymentId",
                table: "Payment_cheques");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Lookup_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Reg_Parent_RegParentId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherStatusId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherTypeId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Payments_PaymentId",
                table: "Student_fees");


            migrationBuilder.DropColumn(
                name: "Note2",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Student_fees",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "Db",
                table: "Student_fees",
                newName: "FinItemVoucherSequence");

            migrationBuilder.RenameColumn(
                name: "Cr",
                table: "Student_fees",
                newName: "Debit");

            migrationBuilder.RenameIndex(
                name: "IX_Student_fees_PaymentId",
                table: "Student_fees",
                newName: "IX_Student_fees_PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "chequeValue",
                table: "Payment_cheques",
                newName: "ChequeValue");

            migrationBuilder.RenameColumn(
                name: "chequeNo",
                table: "Payment_cheques",
                newName: "ChequeNo");

            migrationBuilder.RenameColumn(
                name: "chequeDate",
                table: "Payment_cheques",
                newName: "ChequeDate");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Payment_cheques",
                newName: "StudentFeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_PaymentId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_StudentFeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_YearId",
                table: "Payment",
                newName: "IX_Payment_YearId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_VoucherTypeId",
                table: "Payment",
                newName: "IX_Payment_VoucherTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_VoucherStatusId",
                table: "Payment",
                newName: "IX_Payment_VoucherStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_RegParentId",
                table: "Payment",
                newName: "IX_Payment_RegParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payment",
                newName: "IX_Payment_PaymentMethodId");

            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransferDate",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransferNo",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisaCardNo",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VoucherDate",
                table: "Student_fees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VoucherStatusId",
                table: "Student_fees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoucherTypeId",
                table: "Student_fees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FinItemVoucherMaxSequence",
                table: "Fin_items",
                nullable: true);


            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_VoucherStatusId",
                table: "Student_fees",
                column: "VoucherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_VoucherTypeId",
                table: "Student_fees",
                column: "VoucherTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Lkp_Lookup_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Reg_Parent_RegParentId",
                table: "Payment",
                column: "RegParentId",
                principalTable: "Reg_Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Lkp_Lookup_VoucherStatusId",
                table: "Payment",
                column: "VoucherStatusId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

           

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Lkp_Year_YearId",
                table: "Payment",
                column: "YearId",
                principalTable: "Lkp_Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques",
                column: "StudentFeeId",
                principalTable: "Student_fees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Lkp_Lookup_PaymentMethodId",
                table: "Student_fees",
                column: "PaymentMethodId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

           

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Lkp_Lookup_PaymentMethodId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Reg_Parent_RegParentId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Lkp_Lookup_VoucherStatusId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Lkp_Lookup_VoucherTypeId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Lkp_Year_YearId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_cheques_Student_fees_StudentFeeId",
                table: "Payment_cheques");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Lkp_Lookup_PaymentMethodId",
                table: "Student_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Lkp_Lookup_VoucherStatusId",
                table: "Student_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Lkp_Lookup_VoucherTypeId",
                table: "Student_fees");

            migrationBuilder.DropIndex(
                name: "IX_Student_fees_VoucherStatusId",
                table: "Student_fees");

            migrationBuilder.DropIndex(
                name: "IX_Student_fees_VoucherTypeId",
                table: "Student_fees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "TransferDate",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "TransferNo",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "VisaCardNo",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "VoucherDate",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "VoucherStatusId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "VoucherTypeId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "FinItemVoucherMaxSequence",
                table: "Fin_items");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "Student_fees",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "FinItemVoucherSequence",
                table: "Student_fees",
                newName: "Db");

            migrationBuilder.RenameColumn(
                name: "Debit",
                table: "Student_fees",
                newName: "Cr");

            migrationBuilder.RenameIndex(
                name: "IX_Student_fees_PaymentMethodId",
                table: "Student_fees",
                newName: "IX_Student_fees_PaymentId");

            migrationBuilder.RenameColumn(
                name: "ChequeValue",
                table: "Payment_cheques",
                newName: "chequeValue");

            migrationBuilder.RenameColumn(
                name: "ChequeNo",
                table: "Payment_cheques",
                newName: "chequeNo");

            migrationBuilder.RenameColumn(
                name: "ChequeDate",
                table: "Payment_cheques",
                newName: "chequeDate");

            migrationBuilder.RenameColumn(
                name: "StudentFeeId",
                table: "Payment_cheques",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_cheques_StudentFeeId",
                table: "Payment_cheques",
                newName: "IX_Payment_cheques_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_YearId",
                table: "Payments",
                newName: "IX_Payments_YearId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_VoucherTypeId",
                table: "Payments",
                newName: "IX_Payments_VoucherTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_VoucherStatusId",
                table: "Payments",
                newName: "IX_Payments_VoucherStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_RegParentId",
                table: "Payments",
                newName: "IX_Payments_RegParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payments",
                newName: "IX_Payments_PaymentMethodId");

            migrationBuilder.AddColumn<string>(
                name: "Note2",
                table: "Payments",
                nullable: true);

           

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_cheques_Payments_PaymentId",
                table: "Payment_cheques",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Reg_Parent_RegParentId",
                table: "Payments",
                column: "RegParentId",
                principalTable: "Reg_Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherStatusId",
                table: "Payments",
                column: "VoucherStatusId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherTypeId",
                table: "Payments",
                column: "VoucherTypeId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments",
                column: "YearId",
                principalTable: "Lkp_Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Payments_PaymentId",
                table: "Student_fees",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
