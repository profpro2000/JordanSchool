using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class ChangeClassesYearV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_Class_Lkp_Lookup_YearId",
                table: "Lkp_Class");

            migrationBuilder.AddColumn<int>(
                name: "LkpLookupId",
                table: "Lkp_Class",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_LkpLookupId",
                table: "Lkp_Class",
                column: "LkpLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_Class_Lkp_Lookup_LkpLookupId",
                table: "Lkp_Class",
                column: "LkpLookupId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_Class_Lkp_Year_YearId",
                table: "Lkp_Class",
                column: "YearId",
                principalTable: "Lkp_Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_Class_Lkp_Lookup_LkpLookupId",
                table: "Lkp_Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_Class_Lkp_Year_YearId",
                table: "Lkp_Class");

            migrationBuilder.DropIndex(
                name: "IX_Lkp_Class_LkpLookupId",
                table: "Lkp_Class");

            migrationBuilder.DropColumn(
                name: "LkpLookupId",
                table: "Lkp_Class");

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_Class_Lkp_Lookup_YearId",
                table: "Lkp_Class",
                column: "YearId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
