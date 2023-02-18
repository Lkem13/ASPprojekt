using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _21Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusModel",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StatusModel",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionModel",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "StatusModel");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "PositionModel");

            migrationBuilder.RenameColumn(
                name: "StatusModel",
                table: "AspNetUsers",
                newName: "Status");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusModel",
                table: "StatusModel",
                column: "StatusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel",
                column: "PositionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusModel",
                table: "StatusModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "StatusModel",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "PositionModel",
                newName: "Positions");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AspNetUsers",
                newName: "StatusModel");

            migrationBuilder.AddColumn<string>(
                name: "PositionModel",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StatusModel",
                table: "AspNetUsers",
                column: "StatusModel");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel",
                principalTable: "Positions",
                principalColumn: "PositionName");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusModel",
                table: "AspNetUsers",
                column: "StatusModel",
                principalTable: "Statuses",
                principalColumn: "StatusID");
        }
    }
}
