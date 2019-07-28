using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class StudentFeesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Reg_Stud_StudentId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Student_fees");

            migrationBuilder.AlterColumn<int>(
                name: "YearId",
                table: "Student_fees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Student_fees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FinItemId",
                table: "Student_fees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Cr",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Db",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegStudId",
                table: "Student_fees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_RegStudId",
                table: "Student_fees",
                column: "RegStudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Reg_Stud_RegStudId",
                table: "Student_fees",
                column: "RegStudId",
                principalTable: "Reg_Stud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Adm_Stud_StudentId",
                table: "Student_fees",
                column: "StudentId",
                principalTable: "Adm_Stud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Reg_Stud_RegStudId",
                table: "Student_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Adm_Stud_StudentId",
                table: "Student_fees");

            migrationBuilder.DropIndex(
                name: "IX_Student_fees_RegStudId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "Cr",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "Db",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "RegStudId",
                table: "Student_fees");

            migrationBuilder.AlterColumn<int>(
                name: "YearId",
                table: "Student_fees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Student_fees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FinItemId",
                table: "Student_fees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Student_fees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Reg_Stud_StudentId",
                table: "Student_fees",
                column: "StudentId",
                principalTable: "Reg_Stud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
