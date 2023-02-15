using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _14Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusModel",
                table: "StatusModel");

            migrationBuilder.RenameTable(
                name: "StatusModel",
                newName: "Statuses");

            migrationBuilder.AlterColumn<string>(
                name: "statusType",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "StatusModel");

            migrationBuilder.AlterColumn<int>(
                name: "statusType",
                table: "StatusModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusModel",
                table: "StatusModel",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusID",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "StatusModel",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
