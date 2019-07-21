using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Fees_Lkp_Lookup_YearId",
                table: "School_Fees");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Student_fees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    VoucherId = table.Column<string>(nullable: true),
                    VoucherDate = table.Column<DateTime>(nullable: false),
                    VoucherTypeId = table.Column<int>(nullable: false),
                    VoucherTypeId1 = table.Column<int>(nullable: true),
                    VoucherStatusId = table.Column<string>(nullable: true),
                    Debit = table.Column<int>(nullable: false),
                    Credit = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Lkp_Lookup_VoucherTypeId",
                        column: x => x.VoucherTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Lkp_Lookup_VoucherTypeId1",
                        column: x => x.VoucherTypeId1,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_PaymentId",
                table: "Student_fees",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherTypeId",
                table: "Payments",
                column: "VoucherTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherTypeId1",
                table: "Payments",
                column: "VoucherTypeId1");

            

            migrationBuilder.AddForeignKey(
                name: "FK_Student_fees_Payments_PaymentId",
                table: "Student_fees",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_Fees_Lkp_Year_YearId",
                table: "School_Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_fees_Payments_PaymentId",
                table: "Student_fees");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Student_fees_PaymentId",
                table: "Student_fees");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Student_fees");

            migrationBuilder.AddForeignKey(
                name: "FK_School_Fees_Lkp_Lookup_YearId",
                table: "School_Fees",
                column: "YearId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
