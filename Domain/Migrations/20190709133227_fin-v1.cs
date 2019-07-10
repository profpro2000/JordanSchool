using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class finv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fin_items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ArDesc = table.Column<string>(nullable: true),
                    LaDesc = table.Column<string>(nullable: true),
                    CDType = table.Column<string>(nullable: true),
                    VPType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fin_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class_fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    LkpClassId = table.Column<int>(nullable: true),
                    SectionId = table.Column<int>(nullable: false),
                    LkpSectionId = table.Column<int>(nullable: true),
                    FinItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Class_LkpClassId",
                        column: x => x.LkpClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Section_LkpSectionId",
                        column: x => x.LkpSectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_fees_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School_Fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    FinItemId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_Fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_Fees_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_Fees_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student_fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    FinItemId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_fees_Fin_items_FinItemId",
                        column: x => x.FinItemId,
                        principalTable: "Fin_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_fees_Reg_Stud_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Reg_Stud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_fees_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_FinItemId",
                table: "Class_fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_LkpClassId",
                table: "Class_fees",
                column: "LkpClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_LkpSectionId",
                table: "Class_fees",
                column: "LkpSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_fees_YearId",
                table: "Class_fees",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_FinItemId",
                table: "School_Fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_SchoolId",
                table: "School_Fees",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Fees_YearId",
                table: "School_Fees",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_FinItemId",
                table: "Student_fees",
                column: "FinItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_StudentId",
                table: "Student_fees",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_fees_YearId",
                table: "Student_fees",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class_fees");

            migrationBuilder.DropTable(
                name: "School_Fees");

            migrationBuilder.DropTable(
                name: "Student_fees");

            migrationBuilder.DropTable(
                name: "Fin_items");
        }
    }
}
