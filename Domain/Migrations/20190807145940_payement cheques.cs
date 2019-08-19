using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class payementcheques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodId",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransferDate",
                table: "Payments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TransferNo",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisaCardNo",
                table: "Payments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentCheques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    chequeNo = table.Column<string>(nullable: true),
                    chequeDate = table.Column<DateTime>(nullable: false),
                    chequeValue = table.Column<int>(nullable: false),
                    BankId = table.Column<int>(nullable: true),
                    PaymentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCheques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentCheques_Lkp_Lookup_BankId",
                        column: x => x.BankId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentCheques_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCheques_BankId",
                table: "PaymentCheques",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentCheques_PaymentId",
                table: "PaymentCheques",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Lookup_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentCheques");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TransferDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TransferNo",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "VisaCardNo",
                table: "Payments");
        }
    }
}
