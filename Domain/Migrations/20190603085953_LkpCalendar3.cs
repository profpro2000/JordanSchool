using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LkpCalendar3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemsId",
                table: "LkpCalendar");

            migrationBuilder.DropIndex(
                name: "IX_LkpCalendar_ItemsId",
                table: "LkpCalendar");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "LkpCalendar");

            migrationBuilder.CreateIndex(
                name: "IX_LkpCalendar_ItemId",
                table: "LkpCalendar",
                column: "ItemId");

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

            migrationBuilder.DropIndex(
                name: "IX_LkpCalendar_ItemId",
                table: "LkpCalendar");

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "LkpCalendar",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LkpCalendar_ItemsId",
                table: "LkpCalendar",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemsId",
                table: "LkpCalendar",
                column: "ItemsId",
                principalTable: "LkpItemCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
