using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _9Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town", "ZipCode" },
                values: new object[] { 1, "Wielicka 13/5A", "Cracow", "31-271" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town", "ZipCode" },
                values: new object[] { 2, "Zielona 11", "Warsaw", "44-223" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);
        }
    }
}
