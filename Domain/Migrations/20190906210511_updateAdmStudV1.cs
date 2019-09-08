using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateAdmStudV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "Adm_Stud",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "Adm_Stud");
        }
    }
}
