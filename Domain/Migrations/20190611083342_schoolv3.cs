using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class schoolv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fin_item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    IsUpdatable = table.Column<int>(nullable: false),
                    VisibleToId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fin_item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fin_item_Lkp_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Lkp_School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fin_item_Lkp_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fin_item_Lkp_Lookup_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fin_item_Lkp_Lookup_VisibleToId",
                        column: x => x.VisibleToId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fin_item_SchoolId",
                table: "Fin_item",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_item_SectionId",
                table: "Fin_item",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_item_TypeId",
                table: "Fin_item",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fin_item_VisibleToId",
                table: "Fin_item",
                column: "VisibleToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fin_item");
        }
    }
}
