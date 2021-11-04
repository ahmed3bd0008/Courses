using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class makeCourseRefranceRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseRefrance",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "CourseRefrance",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseRefrance",
                table: "Courses",
                column: "CourseRefrance",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseRefrance",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "CourseRefrance",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseRefrance",
                table: "Courses",
                column: "CourseRefrance",
                unique: true,
                filter: "[CourseRefrance] IS NOT NULL");
        }
    }
}
