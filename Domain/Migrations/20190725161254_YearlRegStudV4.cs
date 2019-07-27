﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class YearlRegStudV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reg_StudYearly_Adm_Stud_StudId",
                table: "Reg_StudYearly");

            migrationBuilder.DropIndex(
                name: "IX_Reg_StudYearly_StudId",
                table: "Reg_StudYearly");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reg_StudYearly_StudId",
                table: "Reg_StudYearly",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reg_StudYearly_Adm_Stud_StudId",
                table: "Reg_StudYearly",
                column: "StudId",
                principalTable: "Adm_Stud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
