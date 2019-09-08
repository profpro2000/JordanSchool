using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateAdmStudV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DescountValue",
                table: "Adm_Stud",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "ClassPrice",
                table: "Adm_Stud",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DescountValue",
                table: "Adm_Stud",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassPrice",
                table: "Adm_Stud",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
