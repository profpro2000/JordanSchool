using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateLookupV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TourName",
                table: "LkpTour");

            migrationBuilder.AddColumn<int>(
                name: "TourNameId",
                table: "LkpTour",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArDescription",
                table: "Lkp_School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngDescription",
                table: "Lkp_School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PoBox",
                table: "Lkp_School",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LkpTour_TourNameId",
                table: "LkpTour",
                column: "TourNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpTour_Lkp_Lookup_TourNameId",
                table: "LkpTour",
                column: "TourNameId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpTour_Lkp_Lookup_TourNameId",
                table: "LkpTour");

            migrationBuilder.DropIndex(
                name: "IX_LkpTour_TourNameId",
                table: "LkpTour");

            migrationBuilder.DropColumn(
                name: "TourNameId",
                table: "LkpTour");

            migrationBuilder.DropColumn(
                name: "ArDescription",
                table: "Lkp_School");

            migrationBuilder.DropColumn(
                name: "EngDescription",
                table: "Lkp_School");

            migrationBuilder.DropColumn(
                name: "PoBox",
                table: "Lkp_School");

            migrationBuilder.AddColumn<string>(
                name: "TourName",
                table: "LkpTour",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
