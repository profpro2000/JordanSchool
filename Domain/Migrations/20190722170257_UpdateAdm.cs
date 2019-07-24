using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UpdateAdm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiseaseName",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstLName",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNum",
                table: "Adm_Stud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JoinTermId",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JoinYearId",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicamentName",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousSchool",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudBrotherSeq",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudFace",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudHealthId",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudMobile",
                table: "Adm_Stud",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_JoinTermId",
                table: "Adm_Stud",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_JoinYearId",
                table: "Adm_Stud",
                column: "JoinYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_StudHealthId",
                table: "Adm_Stud",
                column: "StudHealthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_JoinTermId",
                table: "Adm_Stud",
                column: "JoinTermId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_JoinYearId",
                table: "Adm_Stud",
                column: "JoinYearId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_StudHealthId",
                table: "Adm_Stud",
                column: "StudHealthId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_JoinTermId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_JoinYearId",
                table: "Adm_Stud");

            migrationBuilder.DropForeignKey(
                name: "FK_Adm_Stud_Lkp_Lookup_StudHealthId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_JoinTermId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_JoinYearId",
                table: "Adm_Stud");

            migrationBuilder.DropIndex(
                name: "IX_Adm_Stud_StudHealthId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "DiseaseName",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "FirstLName",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "IdNum",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "JoinTermId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "JoinYearId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "MedicamentName",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "PreviousSchool",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "StudBrotherSeq",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "StudFace",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "StudHealthId",
                table: "Adm_Stud");

            migrationBuilder.DropColumn(
                name: "StudMobile",
                table: "Adm_Stud");
        }
    }
}
