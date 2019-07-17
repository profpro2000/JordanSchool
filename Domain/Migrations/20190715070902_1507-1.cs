using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class _15071 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_fees_Fin_items_FinItemId",
                table: "Class_fees");

           



            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_ClassId",
                table: "Class_fees",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_SectionId",
                table: "Class_fees",
                column: "SectionId");



            migrationBuilder.AddForeignKey(
                name: "FK_Class_fees_Fin_items_FinItemId",
                table: "Class_fees",
                column: "FinItemId",
                principalTable: "Fin_items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_fees_Lkp_Class_ClassId",
                table: "Class_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_fees_Fin_items_FinItemId",
                table: "Class_fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_fees_Lkp_Section_SectionId",
                table: "Class_fees");

            migrationBuilder.DropIndex(
                name: "IX_Class_fees_ClassId",
                table: "Class_fees");

            migrationBuilder.DropIndex(
                name: "IX_Class_fees_SectionId",
                table: "Class_fees");

            migrationBuilder.AddColumn<int>(
                name: "LkpClassId",
                table: "Class_fees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LkpSectionId",
                table: "Class_fees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_LkpClassId",
                table: "Class_fees",
                column: "LkpClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_LkpSectionId",
                table: "Class_fees",
                column: "LkpSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_fees_Fin_items_FinItemId",
                table: "Class_fees",
                column: "FinItemId",
                principalTable: "Fin_items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_fees_Lkp_Class_LkpClassId",
                table: "Class_fees",
                column: "LkpClassId",
                principalTable: "Lkp_Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_fees_Lkp_Section_LkpSectionId",
                table: "Class_fees",
                column: "LkpSectionId",
                principalTable: "Lkp_Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
