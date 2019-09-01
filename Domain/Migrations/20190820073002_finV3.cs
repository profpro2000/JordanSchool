using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class finV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinItemOrder",
                table: "Fin_items");

          

            migrationBuilder.CreateTable(
                name: "Payment_cheques",
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
                    table.PrimaryKey("PK_Payment_cheques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_cheques_Lkp_Lookup_BankId",
                        column: x => x.BankId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_cheques_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Payment_cheques_BankId",
                table: "Payment_cheques",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_cheques_PaymentId",
                table: "Payment_cheques",
                column: "PaymentId");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Lookup_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "Payment_cheques");

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

            migrationBuilder.AddColumn<int>(
                name: "FinItemOrder",
                table: "Fin_items",
                nullable: true);
        }
    }
}
