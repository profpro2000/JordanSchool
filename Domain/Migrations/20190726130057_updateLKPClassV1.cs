using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateLKPClassV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassSeq",
                table: "Lkp_Class",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassSeq",
                table: "Lkp_Class");
        }
    }
}
