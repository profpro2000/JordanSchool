using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class fromYaseenV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AlterColumn<int>(
                name: "Debit",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Credit",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Note2",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_YearId",
                table: "Payments",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments",
                column: "YearId",
                principalTable: "Lkp_Year",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Lkp_Year_YearId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_YearId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Note2",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "Debit",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Credit",
                table: "Payments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

               
        }
    }
}
