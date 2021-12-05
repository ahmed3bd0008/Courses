using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class addcoursetrack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseTrackId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "courseTrack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseTrack", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseTrackId",
                table: "Courses",
                column: "CourseTrackId");

            migrationBuilder.AddForeignKey(
                name: "FKcourseTrackId",
                table: "Courses",
                column: "CourseTrackId",
                principalTable: "courseTrack",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKcourseTrackId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "courseTrack");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseTrackId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseTrackId",
                table: "Courses");
        }
    }
}
