using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LookupsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_Calendar_Lkp_Item_Calendar_ItemId",
                table: "Lkp_Calendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Item_Calendar",
                table: "Lkp_Item_Calendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Calendar",
                table: "Lkp_Calendar");

            migrationBuilder.RenameTable(
                name: "Lkp_Item_Calendar",
                newName: "LkpItemCalendar");

            migrationBuilder.RenameTable(
                name: "Lkp_Calendar",
                newName: "LkpCalendar");

            migrationBuilder.RenameIndex(
                name: "IX_Lkp_Calendar_ItemId",
                table: "LkpCalendar",
                newName: "IX_LkpCalendar_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpItemCalendar",
                table: "LkpItemCalendar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpCalendar",
                table: "LkpCalendar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemId",
                table: "LkpCalendar",
                column: "ItemId",
                principalTable: "LkpItemCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemId",
                table: "LkpCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpItemCalendar",
                table: "LkpItemCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpCalendar",
                table: "LkpCalendar");

            migrationBuilder.RenameTable(
                name: "LkpItemCalendar",
                newName: "Lkp_Item_Calendar");

            migrationBuilder.RenameTable(
                name: "LkpCalendar",
                newName: "Lkp_Calendar");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendar_ItemId",
                table: "Lkp_Calendar",
                newName: "IX_Lkp_Calendar_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lkp_Item_Calendar",
                table: "Lkp_Item_Calendar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lkp_Calendar",
                table: "Lkp_Calendar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_Calendar_Lkp_Item_Calendar_ItemId",
                table: "Lkp_Calendar",
                column: "ItemId",
                principalTable: "Lkp_Item_Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
