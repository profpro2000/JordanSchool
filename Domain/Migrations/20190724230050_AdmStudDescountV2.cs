using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AdmStudDescountV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescountAmt",
                table: "Adm_Stud",
                newName: "DescountValue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescountValue",
                table: "Adm_Stud",
                newName: "DescountAmt");
        }
    }
}
