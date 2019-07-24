using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherStatusId",
                table: "Payments",
                column: "VoucherStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherStatusId",
                table: "Payments",
                column: "VoucherStatusId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropIndex(
                name: "IX_Payments_VoucherStatusId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "VoucherTypeId1",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Payments_VoucherTypeId1",
                table: "Payments",
                column: "VoucherTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Lookup_VoucherTypeId1",
                table: "Payments",
                column: "VoucherTypeId1",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
