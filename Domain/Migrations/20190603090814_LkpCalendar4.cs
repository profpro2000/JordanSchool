using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LkpCalendar4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_LkpItemCalendar_ItemId",
                table: "LkpCalendar");

            migrationBuilder.DropIndex(
                name: "IX_LkpCalendar_ItemId",
                table: "LkpCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpItemCalendar",
                table: "LkpItemCalendar");

            migrationBuilder.RenameTable(
                name: "LkpItemCalendar",
                newName: "Lkp_Item_Calendar");

            migrationBuilder.AddColumn<int>(
                name: "ItemxxxId",
                table: "LkpCalendar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lkp_Item_Calendar",
                table: "Lkp_Item_Calendar",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_LkpCalendar_ItemxxxId",
                table: "LkpCalendar",
                column: "ItemxxxId");

            migrationBuilder.AddForeignKey(
                name: "FK_LkpCalendar_Lkp_Item_Calendar_ItemxxxId",
                table: "LkpCalendar",
                column: "ItemxxxId",
                principalTable: "Lkp_Item_Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_Lkp_Item_Calendar_ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.DropIndex(
                name: "IX_LkpCalendar_ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Item_Calendar",
                table: "Lkp_Item_Calendar");

            migrationBuilder.DropColumn(
                name: "ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.RenameTable(
                name: "Lkp_Item_Calendar",
                newName: "LkpItemCalendar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpItemCalendar",
                table: "LkpItemCalendar",
                column: "Id");

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
    }
}
