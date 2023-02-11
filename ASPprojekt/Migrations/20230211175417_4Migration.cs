using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _4Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationModelLocationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "AspNetUsers",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "LocationModelLocationId",
                table: "AspNetUsers",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_LocationModelLocationId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_LocationId");

            migrationBuilder.CreateTable(
                name: "PositionModel",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionModel", x => x.PositionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionId",
                table: "AspNetUsers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "LocationModel",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionId",
                table: "AspNetUsers",
                column: "PositionId",
                principalTable: "PositionModel",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PositionModel");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "AspNetUsers",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "AspNetUsers",
                newName: "LocationModelLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_LocationModelLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationModelLocationId",
                table: "AspNetUsers",
                column: "LocationModelLocationId",
                principalTable: "LocationModel",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
