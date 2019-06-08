using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LkpCalendar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_LkpItemCalendarId",
                table: "LkpCalendar");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "LkpItemCalendar",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "LkpCalendar",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LkpItemCalendarId",
                table: "LkpCalendar",
                newName: "ItemsId");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendar_LkpItemCalendarId",
                table: "LkpCalendar",
                newName: "IX_LkpCalendar_ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemsId",
                table: "LkpCalendar",
                column: "ItemsId",
                principalTable: "LkpItemCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemsId",
                table: "LkpCalendar");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "LkpItemCalendar",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "LkpCalendar",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "ItemsId",
                table: "LkpCalendar",
                newName: "LkpItemCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendar_ItemsId",
                table: "LkpCalendar",
                newName: "IX_LkpCalendar_LkpItemCalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_LkpItemCalendarId",
                table: "LkpCalendar",
                column: "LkpItemCalendarId",
                principalTable: "LkpItemCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
