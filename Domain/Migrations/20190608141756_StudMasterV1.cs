using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class StudMasterV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Master",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    StudNo = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    IdNum = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 75, nullable: false),
                    FirstLName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    StudMobile = table.Column<string>(nullable: true),
                    PreviousSchool = table.Column<string>(nullable: true),
                    JoinYearId = table.Column<int>(nullable: true),
                    JoinTermId = table.Column<int>(nullable: true),
                    SchoolId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: true),
                    JoinClassId = table.Column<int>(nullable: true),
                    JoinClassSeqId = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StudFace = table.Column<string>(nullable: true),
                    StudBrotherSeq = table.Column<int>(nullable: true),
                    StudHealthId = table.Column<int>(nullable: true),
                    DiseaseName = table.Column<string>(nullable: true),
                    MedicamentName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Master", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Lookup_JoinClassSeqId",
                        column: x => x.JoinClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Lookup_JoinTermId",
                        column: x => x.JoinTermId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Lookup_JoinYearId",
                        column: x => x.JoinYearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Stud_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Stud_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Class_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Master_Lkp_Lookup_StudHealthId",
                        column: x => x.StudHealthId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_GenderId",
                table: "Stud_Master",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_JoinClassSeqId",
                table: "Stud_Master",
                column: "JoinClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_JoinTermId",
                table: "Stud_Master",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_JoinYearId",
                table: "Stud_Master",
                column: "JoinYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_ParentId",
                table: "Stud_Master",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_SchoolId",
                table: "Stud_Master",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_SectionId",
                table: "Stud_Master",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_StudHealthId",
                table: "Stud_Master",
                column: "StudHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Master_StudNo",
                table: "Stud_Master",
                column: "StudNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Master");
        }
    }
}
