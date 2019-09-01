using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class imageV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileData",
                table: "Lkp_School",
                newName: "ImageFile");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Lkp_School",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Lkp_School");

            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Lkp_School",
                newName: "FileData");
        }
    }
}
