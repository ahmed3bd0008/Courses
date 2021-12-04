using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class deleterelationkeyappuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "UserPhotoId",
                table: "Photo");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_RelationKey",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RelationKey",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "UserPhotoId",
                table: "Photo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "UserPhotoId",
                table: "Photo");

            migrationBuilder.AddColumn<Guid>(
                name: "RelationKey",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_RelationKey",
                table: "AspNetUsers",
                column: "RelationKey");

            migrationBuilder.AddForeignKey(
                name: "UserPhotoId",
                table: "Photo",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "RelationKey",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
