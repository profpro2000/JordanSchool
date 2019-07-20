using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UsersV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsSuperAdmin",
                table: "Sys_Users",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsSuperAdmin",
                table: "Sys_Users",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
