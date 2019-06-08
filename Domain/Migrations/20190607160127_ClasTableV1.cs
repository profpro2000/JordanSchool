using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class ClasTableV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookupName",
                table: "Lkp_Lookup",
                newName: "AName");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Lkp_Lookup",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lkp_Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Aname = table.Column<string>(maxLength: 100, nullable: false),
                    Lname = table.Column<string>(maxLength: 100, nullable: true),
                    Amt = table.Column<int>(maxLength: 10, nullable: false, defaultValue: 0),
                    Capacity = table.Column<int>(maxLength: 3, nullable: false, defaultValue: 0),
                    Age = table.Column<float>(maxLength: 2, nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_Class_Lkp_Lookup_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_SchoolId",
                table: "Lkp_Class",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_SectionId",
                table: "Lkp_Class",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Class_YearId",
                table: "Lkp_Class",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lkp_Class");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Lkp_Lookup");

            migrationBuilder.RenameColumn(
                name: "AName",
                table: "Lkp_Lookup",
                newName: "LookupName");
        }
    }
}
