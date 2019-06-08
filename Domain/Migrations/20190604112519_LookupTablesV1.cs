using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LookupTablesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Lkp_Item_Calendar");

            migrationBuilder.RenameTable(
                name: "LkpCalendars",
                newName: "Lkp_Calendar");

            migrationBuilder.RenameIndex(
                name: "IX_LkpCalendars_ItemId",
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

            migrationBuilder.CreateTable(
                name: "Lkp_Lookup_Type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Lookup_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lkp_Lookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    LookupName = table.Column<string>(maxLength: 200, nullable: false),
                    Value = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lkp_Lookup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lkp_Lookup_Lkp_Lookup_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Lkp_Lookup_Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lkp_Lookup_TypeId",
                table: "Lkp_Lookup",
                column: "TypeId");

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

            migrationBuilder.DropTable(
                name: "Lkp_Lookup");

            migrationBuilder.DropTable(
                name: "Lkp_Lookup_Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Item_Calendar",
                table: "Lkp_Item_Calendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lkp_Calendar",
                table: "Lkp_Calendar");

            migrationBuilder.RenameTable(
                name: "Lkp_Item_Calendar",
                newName: "LkpItemCalendars");

            migrationBuilder.RenameTable(
                name: "Lkp_Calendar",
                newName: "LkpCalendars");

            migrationBuilder.RenameIndex(
                name: "IX_Lkp_Calendar_ItemId",
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
    }
}
