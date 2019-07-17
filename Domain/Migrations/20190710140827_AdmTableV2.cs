using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AdmTableV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adm_Stud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    StudNo = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    LkpSchoolId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: false),
                    LkpSectionId = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: true),
                    NationalityId = table.Column<int>(nullable: false),
                    ReligionId = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    ClassSeqId = table.Column<int>(nullable: true),
                    TourId = table.Column<int>(nullable: false),
                    TourTypeId = table.Column<int>(nullable: false),
                    BusId = table.Column<int>(nullable: false),
                    TourPrice = table.Column<int>(nullable: false),
                    ApprovedId = table.Column<int>(nullable: false),
                    ApprovedDate = table.Column<DateTime>(nullable: false),
                    StudentBrotherSeq = table.Column<int>(nullable: false),
                    BrotherDescountType = table.Column<int>(nullable: false),
                    BusNote = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    LkpLookupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm_Stud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ApprovedId",
                        column: x => x.ApprovedId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Lkp_Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ClassSeqId",
                        column: x => x.ClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_LkpLookupId",
                        column: x => x.LkpLookupId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_School_LkpSchoolId",
                        column: x => x.LkpSchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Section_LkpSectionId",
                        column: x => x.LkpSectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Reg_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_LkpTour_TourId",
                        column: x => x.TourId,
                        principalTable: "LkpTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_TourTypeId",
                        column: x => x.TourTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adm_Stud_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ApprovedId",
                table: "Adm_Stud",
                column: "ApprovedId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_BusId",
                table: "Adm_Stud",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ClassId",
                table: "Adm_Stud",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ClassSeqId",
                table: "Adm_Stud",
                column: "ClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_GenderId",
                table: "Adm_Stud",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpLookupId",
                table: "Adm_Stud",
                column: "LkpLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpSchoolId",
                table: "Adm_Stud",
                column: "LkpSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_LkpSectionId",
                table: "Adm_Stud",
                column: "LkpSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_NationalityId",
                table: "Adm_Stud",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ParentId",
                table: "Adm_Stud",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_ReligionId",
                table: "Adm_Stud",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_TourId",
                table: "Adm_Stud",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_TourTypeId",
                table: "Adm_Stud",
                column: "TourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Adm_Stud_YearId",
                table: "Adm_Stud",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm_Stud");
        }
    }
}
