using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class RolesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SysUsersId",
                table: "Sys_Roles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Users_Roles_RoleId",
                table: "Sys_Users_Roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Users_Roles_UserId",
                table: "Sys_Users_Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Roles_SysUsersId",
                table: "Sys_Roles",
                column: "SysUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Role_Forms_FormId",
                table: "Sys_Role_Forms",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Sys_Role_Forms_RoleId",
                table: "Sys_Role_Forms",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Role_Forms_Sys_Forms_FormId",
                table: "Sys_Role_Forms",
                column: "FormId",
                principalTable: "Sys_Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Role_Forms_Sys_Roles_RoleId",
                table: "Sys_Role_Forms",
                column: "RoleId",
                principalTable: "Sys_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Roles_Sys_Users_SysUsersId",
                table: "Sys_Roles",
                column: "SysUsersId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Users_Roles_Sys_Roles_RoleId",
                table: "Sys_Users_Roles",
                column: "RoleId",
                principalTable: "Sys_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Users_Roles_Sys_Users_UserId",
                table: "Sys_Users_Roles",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Role_Forms_Sys_Forms_FormId",
                table: "Sys_Role_Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Role_Forms_Sys_Roles_RoleId",
                table: "Sys_Role_Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Roles_Sys_Users_SysUsersId",
                table: "Sys_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Users_Roles_Sys_Roles_RoleId",
                table: "Sys_Users_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Users_Roles_Sys_Users_UserId",
                table: "Sys_Users_Roles");

            migrationBuilder.DropIndex(
                name: "IX_Sys_Users_Roles_RoleId",
                table: "Sys_Users_Roles");

            migrationBuilder.DropIndex(
                name: "IX_Sys_Users_Roles_UserId",
                table: "Sys_Users_Roles");

            migrationBuilder.DropIndex(
                name: "IX_Sys_Roles_SysUsersId",
                table: "Sys_Roles");

            migrationBuilder.DropIndex(
                name: "IX_Sys_Role_Forms_FormId",
                table: "Sys_Role_Forms");

            migrationBuilder.DropIndex(
                name: "IX_Sys_Role_Forms_RoleId",
                table: "Sys_Role_Forms");

            migrationBuilder.DropColumn(
                name: "SysUsersId",
                table: "Sys_Roles");
        }
    }
}
