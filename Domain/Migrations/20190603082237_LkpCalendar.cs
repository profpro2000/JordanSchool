using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class LkpCalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LkpCalendar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    LkpItemCalendarId = table.Column<int>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LkpCalendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LkpCalendar_LkpItemCalendar_LkpItemCalendarId",
                        column: x => x.LkpItemCalendarId,
                        principalTable: "LkpItemCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LkpCalendar_LkpItemCalendarId",
                table: "LkpCalendar",
                column: "LkpItemCalendarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LkpCalendar");
        }
    }
}
