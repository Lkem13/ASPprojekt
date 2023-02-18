using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _27Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "23bc491a-8a66-4b02-89b4-d5af23e8bc9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "484a8207-f23e-45e1-8fab-c9eef6d3a3f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20649e08-3513-4f16-8b0e-d2a154a782ce", true, "AQAAAAEAACcQAAAAEPkz5mBNe0OYbO3ePzj1WpAIrW9yCqv+SiJRgR6UbCJfUqY4UVo5SHhiZY0IWPz5cQ==", "51c93181-1cb6-43fe-9768-a68e111faf4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87223ac7-0962-495b-bada-89683d9fe98c", true, "AQAAAAEAACcQAAAAEBhyy389mj+G6R+UeDfItS1IfMKWJ5/JCWdSrUtYoAc5e8LH2nwxRERMIlx9rjPQqw==", "b3176684-1b4f-4195-abad-fdd43e9357d6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3eee4d9c-53e9-40ca-af55-acd74f2665d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "1f013901-9003-4a81-abfd-8bd71a904917");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf43693-9539-4463-ab6e-f7c5ce433206", false, "AQAAAAEAACcQAAAAEF1LnPvknP7+4GxHBwP2aVU8ko5MKyr6Glkk55yC/SW97yMufzXoO1+2fyISlXsN6w==", "e6848f41-dfd7-4657-80fd-f27cf8e1cc4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3a95bf-0321-42f9-9c2c-954e5a6a15b8", false, "AQAAAAEAACcQAAAAEFp6jZn3Kded5tppTdHwzb/GrPE2gU4RxtHUe8Nq+BEActlYfSXEMlQBSvm8I7Z4ZQ==", "6d1fa9fe-ea30-4cc7-902a-1d648a7472e4" });
        }
    }
}
