using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class RegStudV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Master");

            migrationBuilder.DropTable(
                name: "Stud_Parent");

            migrationBuilder.CreateTable(
                name: "Reg_Parent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdNum = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    SecondName = table.Column<string>(maxLength: 100, nullable: false),
                    FamilyName = table.Column<string>(maxLength: 100, nullable: false),
                    FirstLName = table.Column<string>(nullable: true),
                    SecondLName = table.Column<string>(nullable: true),
                    FamilyLName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Locality1 = table.Column<string>(nullable: true),
                    Locality2 = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    BuildingNo = table.Column<string>(nullable: true),
                    FatherEducationId = table.Column<int>(nullable: true),
                    FatherSpec = table.Column<string>(nullable: true),
                    MatherEducationId = table.Column<int>(nullable: true),
                    MatherSpec = table.Column<string>(nullable: true),
                    ParentRelationId = table.Column<int>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    ParentWork = table.Column<string>(nullable: true),
                    FamilySize = table.Column<int>(nullable: true),
                    FamilyIncome = table.Column<int>(nullable: true),
                    FamilyAssistance = table.Column<string>(nullable: true),
                    RefugeeCardNo = table.Column<int>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    FatherMobile = table.Column<string>(nullable: true),
                    MotherMobile = table.Column<string>(nullable: true),
                    SmsParent = table.Column<int>(nullable: true),
                    SmsMobile = table.Column<string>(nullable: true),
                    ParentEmail = table.Column<string>(nullable: true),
                    ParentFace = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reg_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_CityId",
                        column: x => x.CityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_FatherEducationId",
                        column: x => x.FatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_MatherEducationId",
                        column: x => x.MatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_ParentRelationId",
                        column: x => x.ParentRelationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Parent_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reg_Stud",
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
                    table.PrimaryKey("PK_Reg_Stud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinClassSeqId",
                        column: x => x.JoinClassSeqId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinTermId",
                        column: x => x.JoinTermId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_JoinYearId",
                        column: x => x.JoinYearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Reg_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Reg_Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Class_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reg_Stud_Lkp_Lookup_StudHealthId",
                        column: x => x.StudHealthId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_CityId",
                table: "Reg_Parent",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_FatherEducationId",
                table: "Reg_Parent",
                column: "FatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_MatherEducationId",
                table: "Reg_Parent",
                column: "MatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_NationalityId",
                table: "Reg_Parent",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_ParentRelationId",
                table: "Reg_Parent",
                column: "ParentRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Parent_ReligionId",
                table: "Reg_Parent",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_GenderId",
                table: "Reg_Stud",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinClassSeqId",
                table: "Reg_Stud",
                column: "JoinClassSeqId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinTermId",
                table: "Reg_Stud",
                column: "JoinTermId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_JoinYearId",
                table: "Reg_Stud",
                column: "JoinYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_ParentId",
                table: "Reg_Stud",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_SchoolId",
                table: "Reg_Stud",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_SectionId",
                table: "Reg_Stud",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_StudHealthId",
                table: "Reg_Stud",
                column: "StudHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Reg_Stud_StudNo",
                table: "Reg_Stud",
                column: "StudNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reg_Stud");

            migrationBuilder.DropTable(
                name: "Reg_Parent");

            migrationBuilder.CreateTable(
                name: "Stud_Parent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BuildingNo = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    FamilyAssistance = table.Column<string>(nullable: true),
                    FamilyIncome = table.Column<int>(nullable: true),
                    FamilyLName = table.Column<string>(nullable: true),
                    FamilyName = table.Column<string>(maxLength: 100, nullable: false),
                    FamilySize = table.Column<int>(nullable: true),
                    FatherEducationId = table.Column<int>(nullable: true),
                    FatherMobile = table.Column<string>(nullable: true),
                    FatherSpec = table.Column<string>(nullable: true),
                    FirstLName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    IdNum = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    InsertUser = table.Column<int>(nullable: true),
                    Locality1 = table.Column<string>(nullable: true),
                    Locality2 = table.Column<string>(nullable: true),
                    MatherEducationId = table.Column<int>(nullable: true),
                    MatherSpec = table.Column<string>(nullable: true),
                    MotherMobile = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ParentEmail = table.Column<string>(nullable: true),
                    ParentFace = table.Column<string>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    ParentRelationId = table.Column<int>(nullable: true),
                    ParentWork = table.Column<string>(nullable: true),
                    RefugeeCardNo = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    SecondLName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(maxLength: 100, nullable: false),
                    SmsMobile = table.Column<string>(nullable: true),
                    SmsParent = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_CityId",
                        column: x => x.CityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_FatherEducationId",
                        column: x => x.FatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_MatherEducationId",
                        column: x => x.MatherEducationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_ParentRelationId",
                        column: x => x.ParentRelationId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stud_Parent_Lkp_Lookup_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stud_Master",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    DiseaseName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstLName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 75, nullable: false),
                    GenderId = table.Column<int>(nullable: true),
                    IdNum = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    InsertUser = table.Column<int>(nullable: true),
                    JoinClassId = table.Column<int>(nullable: true),
                    JoinClassSeqId = table.Column<int>(nullable: true),
                    JoinTermId = table.Column<int>(nullable: true),
                    JoinYearId = table.Column<int>(nullable: true),
                    MedicamentName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    PreviousSchool = table.Column<string>(nullable: true),
                    SchoolId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: true),
                    StudBrotherSeq = table.Column<int>(nullable: true),
                    StudFace = table.Column<string>(nullable: true),
                    StudHealthId = table.Column<int>(nullable: true),
                    StudMobile = table.Column<string>(nullable: true),
                    StudNo = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_CityId",
                table: "Stud_Parent",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_FatherEducationId",
                table: "Stud_Parent",
                column: "FatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_MatherEducationId",
                table: "Stud_Parent",
                column: "MatherEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_NationalityId",
                table: "Stud_Parent",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_ParentRelationId",
                table: "Stud_Parent",
                column: "ParentRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Parent_ReligionId",
                table: "Stud_Parent",
                column: "ReligionId");
        }
    }
}
