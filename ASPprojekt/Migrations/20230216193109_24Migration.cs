using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _24Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PositionModel",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel",
                principalTable: "Positions",
                principalColumn: "PositionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionModel",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
