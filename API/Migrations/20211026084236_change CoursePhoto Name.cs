using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class changeCoursePhotoName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoursePhotos",
                table: "Courses",
                newName: "CoursePhoto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoursePhoto",
                table: "Courses",
                newName: "CoursePhotos");
        }
    }
}
