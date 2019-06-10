using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class documentv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lkp_document",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InsertUser = table.Column<int>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: true),
                    UpdateUser = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    DocumentId = table.Column<int>(maxLength: 200, nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    MandotoryId = table.Column<int>(nullable: false),
                    ActiveId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkp_document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lkp_document_Lkp_Lookup_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_lkp_document_Lkp_Lookup_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Lkp_Lookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lkp_document_DocumentId",
                table: "lkp_document",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_lkp_document_SectionId",
                table: "lkp_document",
                column: "SectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lkp_document");
        }
    }
}
