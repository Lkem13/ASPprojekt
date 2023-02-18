using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _19Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ASPprojektUserLocationModel");

            migrationBuilder.DropTable(
                name: "ASPprojektUserPositionModel");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "AspNetUsers",
                newName: "StatusModel");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_StatusID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_StatusModel");

            migrationBuilder.AddColumn<int>(
                name: "LocationModel",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionModel",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Street", "Town" },
                values: new object[] { "Brak", "Brak" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Street", "Town" },
                values: new object[] { "Wielicka 13/5A", "Cracow" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town" },
                values: new object[] { 3, "Zielona 11", "Warsaw" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationModel",
                table: "AspNetUsers",
                column: "LocationModel");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Locations_LocationModel",
                table: "AspNetUsers",
                column: "LocationModel",
                principalTable: "Locations",
                principalColumn: "LocationId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Locations_LocationModel",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusModel",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocationModel",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "LocationModel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionModel",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StatusModel",
                table: "AspNetUsers",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_StatusModel",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_StatusID");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateTable(
                name: "ASPprojektUserPositionModel",
                columns: table => new
                {
                    PositionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPprojektUserPositionModel", x => new { x.PositionName, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPositionModel_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPositionModel_Positions_PositionName",
                        column: x => x.PositionName,
                        principalTable: "Positions",
                        principalColumn: "PositionName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                columns: new[] { "Street", "Town", "ZipCode" },
                values: new object[] { "Wielicka 13/5A", "Cracow", "31-271" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                columns: new[] { "Street", "Town", "ZipCode" },
                values: new object[] { "Zielona 11", "Warsaw", "44-223" });

            migrationBuilder.CreateIndex(
                name: "IX_ASPprojektUserLocationModel_UsersId",
                table: "ASPprojektUserLocationModel",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ASPprojektUserPositionModel_UsersId",
                table: "ASPprojektUserPositionModel",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID");
        }
    }
}
