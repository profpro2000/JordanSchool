using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UpdateLkpLookupTypesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Editable",
                table: "Lkp_Lookup_Type",
                maxLength: 1,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Lkp_Lookup_Type",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editable",
                table: "Lkp_Lookup_Type");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Lkp_Lookup_Type");
        }
    }
}
