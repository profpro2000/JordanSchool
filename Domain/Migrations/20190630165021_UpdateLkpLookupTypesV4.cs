using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UpdateLkpLookupTypesV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Lkp_Lookup_Type");

            migrationBuilder.AlterColumn<int>(
                name: "Editable",
                table: "Lkp_Lookup_Type",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 1);

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Lkp_Lookup_Type",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Lkp_Lookup_Type");

            migrationBuilder.AlterColumn<int>(
                name: "Editable",
                table: "Lkp_Lookup_Type",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Lkp_Lookup_Type",
                nullable: false,
                defaultValue: 0);
        }
    }
}
