using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class schoolTableV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpSchools_Lkp_Lookup_CitesLookupId",
                table: "LkpSchools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpSchools",
                table: "LkpSchools");

            migrationBuilder.DropIndex(
                name: "IX_LkpSchools_CitesLookupId",
                table: "LkpSchools");

            migrationBuilder.DropColumn(
                name: "CitesLookupId",
                table: "LkpSchools");

            migrationBuilder.RenameTable(
                name: "LkpSchools",
                newName: "Lkp_School");

            migrationBuilder.AlterColumn<string>(
                name: "Aname",
                table: "Lkp_School",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lkp_School",
                table: "Lkp_School",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_School_CityId",
                table: "Lkp_School",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_School_Lkp_Lookup_CityId",
                table: "Lkp_School",
                column: "CityId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_School_Lkp_Lookup_CityId",
                table: "Lkp_School");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_School",
                table: "Lkp_School");

            migrationBuilder.DropIndex(
                name: "IX_Lkp_School_CityId",
                table: "Lkp_School");

            migrationBuilder.RenameTable(
                name: "Lkp_School",
                newName: "LkpSchools");

            migrationBuilder.AlterColumn<string>(
                name: "Aname",
                table: "LkpSchools",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "CitesLookupId",
                table: "LkpSchools",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpSchools",
                table: "LkpSchools",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LkpSchools_CitesLookupId",
                table: "LkpSchools",
                column: "CitesLookupId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpSchools_Lkp_Lookup_CitesLookupId",
                table: "LkpSchools",
                column: "CitesLookupId",
                principalTable: "Lkp_Lookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
