using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _23Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "PositionModel",
                newName: "Positions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "PositionModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionModel",
                table: "PositionModel",
                column: "PositionName");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town" },
                values: new object[] { 1, "Brak", "Brak" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town" },
                values: new object[] { 2, "Wielicka 13/5A", "Cracow" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town" },
                values: new object[] { 3, "Zielona 11", "Warsaw" });
        }
    }
}
