using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class StudParentTableV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Parent",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Parent");
        }
    }
}
