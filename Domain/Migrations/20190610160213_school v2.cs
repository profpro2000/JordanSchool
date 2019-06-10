using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class schoolv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adm_stud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    StudNo = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    ReligionId = table.Column<int>(nullable: false),
                    NationalityId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    SequenceId = table.Column<int>(nullable: false),
                    BusId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
                    IsApproved = table.Column<int>(nullable: false),
                    ApproveDate = table.Column<DateTime>(nullable: true),
                    StudentBrotherSeq = table.Column<int>(nullable: false),
                    DiscountTypeId = table.Column<int>(nullable: false),
                    BusNotes = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adm_stud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Bus_BusId",
                        column: x => x.BusId,
                        principalTable: "Lkp_Bus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_SequenceId",
                        column: x => x.SequenceId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_LkpTour_TourId",
                        column: x => x.TourId,
                        principalTable: "LkpTour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_adm_stud_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lkp_document_ActiveId",
                table: "lkp_document",
                column: "ActiveId");

            migrationBuilder.CreateIndex(
                name: "IX_lkp_document_MandotoryId",
                table: "lkp_document",
                column: "MandotoryId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_BusId",
                table: "adm_stud",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_ClassId",
                table: "adm_stud",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_DiscountTypeId",
                table: "adm_stud",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_GenderId",
                table: "adm_stud",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_NationalityId",
                table: "adm_stud",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_ReligionId",
                table: "adm_stud",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_SchoolId",
                table: "adm_stud",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_SectionId",
                table: "adm_stud",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_SequenceId",
                table: "adm_stud",
                column: "SequenceId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_TourId",
                table: "adm_stud",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_adm_stud_YearId",
                table: "adm_stud",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_lkp_document_Lkp_Lookup_ActiveId",
                table: "lkp_document",
                column: "ActiveId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_lkp_document_Lkp_Lookup_MandotoryId",
                table: "lkp_document",
                column: "MandotoryId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lkp_document_Lkp_Lookup_ActiveId",
                table: "lkp_document");

            migrationBuilder.DropForeignKey(
                name: "FK_lkp_document_Lkp_Lookup_MandotoryId",
                table: "lkp_document");

            migrationBuilder.DropTable(
                name: "adm_stud");

            migrationBuilder.DropIndex(
                name: "IX_lkp_document_ActiveId",
                table: "lkp_document");

            migrationBuilder.DropIndex(
                name: "IX_lkp_document_MandotoryId",
                table: "lkp_document");
        }
    }
}
