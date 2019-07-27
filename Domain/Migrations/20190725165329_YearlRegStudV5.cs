using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class YearlRegStudV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudId",
                table: "Reg_StudYearly",
                newName: "AdmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdmId",
                table: "Reg_StudYearly",
                newName: "StudId");
        }
    }
}
