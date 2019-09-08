using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class lkpclassFeesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassGender",
                table: "Lkp_Class",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Lkp_class_fees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    ClassFees = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_class_fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_class_fees_Lkp_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Lkp_Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lkp_class_fees_Lkp_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Lkp_Year",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_class_fees_ClassId",
                table: "Lkp_class_fees",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_class_fees_YearId",
                table: "Lkp_class_fees",
                column: "YearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lkp_class_fees");

            migrationBuilder.DropColumn(
                name: "ClassGender",
                table: "Lkp_Class");
        }
    }
}
