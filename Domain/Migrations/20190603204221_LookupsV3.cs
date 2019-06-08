using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LookupsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "LkpItemCalendars");

            migrationBuilder.RenameTable(
                name: "LkpCalendar",
                newName: "LkpCalendars");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendar_ItemId",
                table: "LkpCalendars",
                newName: "IX_LkpCalendars_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpItemCalendars",
                table: "LkpItemCalendars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpCalendars",
                table: "LkpCalendars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendars_LkpItemCalendars_ItemId",
                table: "LkpCalendars",
                column: "ItemId",
                principalTable: "LkpItemCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendars_LkpItemCalendars_ItemId",
                table: "LkpCalendars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpItemCalendars",
                table: "LkpItemCalendars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpCalendars",
                table: "LkpCalendars");

            migrationBuilder.RenameTable(
                name: "LkpItemCalendars",
                newName: "LkpItemCalendar");

            migrationBuilder.RenameTable(
                name: "LkpCalendars",
                newName: "LkpCalendar");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendars_ItemId",
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
    }
}
