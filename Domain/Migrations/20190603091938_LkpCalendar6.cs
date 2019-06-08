using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LkpCalendar6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LkpCalendar_Lkp_Item_Calendar_ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LkpCalendar",
                table: "LkpCalendar");

            migrationBuilder.DropIndex(
                name: "IX_LkpCalendar_ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.DropColumn(
                name: "ItemxxxId",
                table: "LkpCalendar");

            migrationBuilder.RenameTable(
                name: "LkpCalendar",
                newName: "Lkp_Calendar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lkp_Calendar",
                table: "Lkp_Calendar",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Calendar_ItemId",
                table: "Lkp_Calendar",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lkp_Calendar_Lkp_Item_Calendar_ItemId",
                table: "Lkp_Calendar",
                column: "ItemId",
                principalTable: "Lkp_Item_Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lkp_Calendar_Lkp_Item_Calendar_ItemId",
                table: "Lkp_Calendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Calendar",
                table: "Lkp_Calendar");

            migrationBuilder.DropIndex(
                name: "IX_Lkp_Calendar_ItemId",
                table: "Lkp_Calendar");

            migrationBuilder.RenameTable(
                name: "Lkp_Calendar",
                newName: "LkpCalendar");

            migrationBuilder.AddColumn<int>(
                name: "ItemxxxId",
                table: "LkpCalendar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LkpCalendar",
                table: "LkpCalendar",
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
    }
}
