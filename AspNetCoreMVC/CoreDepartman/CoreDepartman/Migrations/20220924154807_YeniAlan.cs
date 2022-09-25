using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class YeniAlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels",
                column: "DepartmanID",
                principalTable: "Departmanlars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanID",
                table: "Personels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels",
                column: "DepartmanID",
                principalTable: "Departmanlars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
