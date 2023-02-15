using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _13Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "StatusModel",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "AspNetUsers",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_StatusId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusID",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "StatusModel",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "StatusModel",
                newName: "StatusID");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "AspNetUsers",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_StatusID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusId",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "StatusModel",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
