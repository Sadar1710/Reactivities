using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AutherId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "AutherId",
                table: "Comments",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AutherId",
                table: "Comments",
                newName: "IX_Comments_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Comments",
                newName: "AutherId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                newName: "IX_Comments_AutherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AutherId",
                table: "Comments",
                column: "AutherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
