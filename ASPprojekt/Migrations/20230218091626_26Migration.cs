using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _26Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "3eee4d9c-53e9-40ca-af55-acd74f2665d7", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1f013901-9003-4a81-abfd-8bd71a904917", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LocationModel", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Pesel", "PhoneNumber", "PhoneNumberConfirmed", "PositionModel", "SecurityStamp", "Status", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "acf43693-9539-4463-ab6e-f7c5ce433206", "user@user.user", false, "User", "User", null, false, null, "USER@USER.USER", "USER@USER.USER", "AQAAAAEAACcQAAAAEF1LnPvknP7+4GxHBwP2aVU8ko5MKyr6Glkk55yC/SW97yMufzXoO1+2fyISlXsN6w==", "11111111111", null, false, null, "e6848f41-dfd7-4657-80fd-f27cf8e1cc4b", null, false, null, "user@user.user" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "4d3a95bf-0321-42f9-9c2c-954e5a6a15b8", "admin@admin.admin", false, "Admin", "Admin", null, false, null, "ADMIN@ADMIN.ADMIN", "ADMIN@ADMIN.ADMIN", "AQAAAAEAACcQAAAAEFp6jZn3Kded5tppTdHwzb/GrPE2gU4RxtHUe8Nq+BEActlYfSXEMlQBSvm8I7Z4ZQ==", "00000000000", null, false, null, "6d1fa9fe-ea30-4cc7-902a-1d648a7472e4", null, false, null, "admin@admin.admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");
        }
    }
}
