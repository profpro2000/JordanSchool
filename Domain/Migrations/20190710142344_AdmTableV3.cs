using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AdmTableV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Bus_BusId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_School_LkpSchoolId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Section_LkpSectionId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_LkpTour_TourId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_LkpSchoolId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_LkpSectionId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "LkpSchoolId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "LkpSectionId",
                table: "Adm_Stud");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_SchoolId",
                table: "Adm_Stud",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_SectionId",
                table: "Adm_Stud",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Bus_BusId",
                table: "Adm_Stud",
                column: "BusId",
                principalTable: "Lkp_Bus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_School_SchoolId",
                table: "Adm_Stud",
                column: "SchoolId",
                principalTable: "Lkp_School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Section_SectionId",
                table: "Adm_Stud",
                column: "SectionId",
                principalTable: "Lkp_Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_LkpTour_TourId",
                table: "Adm_Stud",
                column: "TourId",
                principalTable: "LkpTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Bus_BusId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_School_SchoolId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Section_SectionId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_LkpTour_TourId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_SchoolId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_SectionId",
                table: "Adm_Stud");

            migrationBuilder.AddColumn<int>(
                name: "LkpSchoolId",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LkpSectionId",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpSchoolId",
                table: "Adm_Stud",
                column: "LkpSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpSectionId",
                table: "Adm_Stud",
                column: "LkpSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Bus_BusId",
                table: "Adm_Stud",
                column: "BusId",
                principalTable: "Lkp_Bus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_School_LkpSchoolId",
                table: "Adm_Stud",
                column: "LkpSchoolId",
                principalTable: "Lkp_School",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Section_LkpSectionId",
                table: "Adm_Stud",
                column: "LkpSectionId",
                principalTable: "Lkp_Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_LkpTour_TourId",
                table: "Adm_Stud",
                column: "TourId",
                principalTable: "LkpTour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
