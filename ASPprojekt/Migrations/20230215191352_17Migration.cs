using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _17Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_AspNetUsers_ASPprojektUserId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_ASPprojektUserId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "ASPprojektUserId",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "ASPprojektUserLocationModel",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPprojektUserLocationModel", x => new { x.LocationId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ASPprojektUserLocationModel_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASPprojektUserLocationModel_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ASPprojektUserLocationModel_UsersId",
                table: "ASPprojektUserLocationModel",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASPprojektUserLocationModel");

            migrationBuilder.AddColumn<string>(
                name: "ASPprojektUserId",
                table: "Locations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ASPprojektUserId",
                table: "Locations",
                column: "ASPprojektUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_AspNetUsers_ASPprojektUserId",
                table: "Locations",
                column: "ASPprojektUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
