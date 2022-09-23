using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class personeldepartmaniliski1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmanID",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels",
                column: "DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels",
                column: "DepartmanID",
                principalTable: "Departmanlars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmanlars_DepartmanID",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartmanID",
                table: "Personels");
        }
    }
}
