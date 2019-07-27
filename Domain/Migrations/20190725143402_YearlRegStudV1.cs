using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class YearlRegStudV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reg_StudYearly",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: false),
                    StudNo = table.Column<int>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    YearId = table.Column<int>(nullable: true),
                    JoinTermId = table.Column<int>(nullable: true),
                    ClassId = table.Column<int>(nullable: true),
                    ClassPrice = table.Column<int>(nullable: false),
                    ClassSeqId = table.Column<int>(nullable: true),
                    TourId = table.Column<int>(nullable: true),
                    TourTypeId = table.Column<int>(nullable: true),
                    BusId = table.Column<int>(nullable: true),
                    TourPrice = table.Column<int>(nullable: true),
                    ApprovedId = table.Column<int>(nullable: true),
                    ApprovedDate = table.Column<DateTime>(nullable: true),
                    StudentBrotherSeq = table.Column<int>(nullable: true),
                    BrotherDescountType = table.Column<int>(nullable: true),
                    DescountValue = table.Column<double>(nullable: false),
                    BusNote = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    LkpLookupId = table.Column<int>(nullable: true),
                    LkpLookupId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg_StudYearly", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_ApprovedId",
                        column: x => x.ApprovedId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Lkp_Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_ClassSeqId",
                        column: x => x.ClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_JoinTermId",
                        column: x => x.JoinTermId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_LkpLookupId",
                        column: x => x.LkpLookupId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_LkpLookupId1",
                        column: x => x.LkpLookupId1,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Reg_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_LkpTour_TourId",
                        column: x => x.TourId,
                        principalTable: "LkpTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_TourTypeId",
                        column: x => x.TourTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_StudYearly_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_ApprovedId",
                table: "Reg_StudYearly",
                column: "ApprovedId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_BusId",
                table: "Reg_StudYearly",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_ClassId",
                table: "Reg_StudYearly",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_ClassSeqId",
                table: "Reg_StudYearly",
                column: "ClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_JoinTermId",
                table: "Reg_StudYearly",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_LkpLookupId",
                table: "Reg_StudYearly",
                column: "LkpLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_LkpLookupId1",
                table: "Reg_StudYearly",
                column: "LkpLookupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_ParentId",
                table: "Reg_StudYearly",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_SchoolId",
                table: "Reg_StudYearly",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_SectionId",
                table: "Reg_StudYearly",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_TourId",
                table: "Reg_StudYearly",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_TourTypeId",
                table: "Reg_StudYearly",
                column: "TourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_YearId",
                table: "Reg_StudYearly",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reg_StudYearly");
        }
    }
}
