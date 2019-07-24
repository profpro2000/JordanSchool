using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UsersV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sys_UserSchool_SchoolId",
                table: "Sys_UserSchool");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserSchool_SchoolId",
                table: "Sys_UserSchool",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sys_UserSchool_SchoolId",
                table: "Sys_UserSchool");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_UserSchool_SchoolId",
                table: "Sys_UserSchool",
                column: "SchoolId",
                unique: true);
        }
    }
}
