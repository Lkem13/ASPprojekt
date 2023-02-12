using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _7Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationModel",
                table: "LocationModel");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "PositionModel",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "LocationModel",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.CreateTable(
                name: "ASPprojektUserPositionModel",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPprojektUserPositionModel", x => new { x.PositionId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPositionModel_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPositionModel_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "PositionName" },
                values: new object[,]
                {
                    { 1, "Front Desk" },
                    { 2, "Chef" },
                    { 3, "Cook" },
                    { 4, "Hotel Manager" },
                    { 5, "Maid" },
                    { 6, "Barista" },
                    { 7, "Waiter" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ASPprojektUserPositionModel_UsersId",
                table: "ASPprojektUserPositionModel",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Locations_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Locations_LocationId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ASPprojektUserPositionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 7);

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "PositionModel");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "LocationModel");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationModel",
                table: "LocationModel",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionId",
                table: "AspNetUsers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "LocationModel",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionId",
                table: "AspNetUsers",
                column: "PositionId",
                principalTable: "PositionModel",
                principalColumn: "PositionId");
        }
    }
}
