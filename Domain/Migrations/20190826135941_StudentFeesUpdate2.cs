using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class StudentFeesUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoucherId",
                table: "Student_fees");

            migrationBuilder.RenameColumn(
                name: "Db",
                table: "Student_fees",
                newName: "FinItemVoucherSequence");

            migrationBuilder.RenameColumn(
                name: "Cr",
                table: "Student_fees",
                newName: "Debit");

            migrationBuilder.AddColumn<int>(
                name: "Credit",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinItemVoucherMaxSequence",
                table: "Fin_items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credit",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "FinItemVoucherMaxSequence",
                table: "Fin_items");

            migrationBuilder.RenameColumn(
                name: "FinItemVoucherSequence",
                table: "Student_fees",
                newName: "Db");

            migrationBuilder.RenameColumn(
                name: "Debit",
                table: "Student_fees",
                newName: "Cr");

            migrationBuilder.AddColumn<string>(
                name: "VoucherId",
                table: "Student_fees",
                nullable: true);
        }
    }
}
