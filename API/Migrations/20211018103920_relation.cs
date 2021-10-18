using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_courseLevels_courseLevelId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseLevels",
                table: "courseLevels");

            migrationBuilder.RenameTable(
                name: "courseLevels",
                newName: "CourseLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseLevels",
                table: "CourseLevels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseLevels_courseLevelId",
                table: "Courses",
                column: "courseLevelId",
                principalTable: "CourseLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseLevels_courseLevelId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseLevels",
                table: "CourseLevels");

            migrationBuilder.RenameTable(
                name: "CourseLevels",
                newName: "courseLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseLevels",
                table: "courseLevels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_courseLevels_courseLevelId",
                table: "Courses",
                column: "courseLevelId",
                principalTable: "courseLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
