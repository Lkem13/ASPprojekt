using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _8Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ba07699e-4cdf-4fb3-8f80-239beb618069");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "58713ba7-4c6a-4941-9756-99a89e1c0a01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf0b320-e54d-469d-93ad-282be6487e2b", "AQAAAAEAACcQAAAAEPPYeeLpZjmYRkPYCmApp/6ej73ZtW33c1V8oUG+SJusoARcpRNLKg4Xy0PfAKI/Cw==", "020799c9-fa82-482f-8a43-b95ca09ebe54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0220eabd-4f71-433d-8774-b9b9ce612791", "AQAAAAEAACcQAAAAEHhuwZBaTXqpnAv5JhueCsDBwTcY9CsI13n7N7AVIK5HwYRe34Dvsa2qg78PfgD4Ww==", "91ff8f78-486c-493c-acd1-c1fdb92964b8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LocationModel", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Pesel", "PhoneNumber", "PhoneNumberConfirmed", "PositionModel", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "668f8372-0c7a-4721-bf5f-b2fba5fa0642", "user23user.user", true, "User3", "User3", null, false, null, "USER3@USER.USER", "USER3@USER.USER", "AQAAAAEAACcQAAAAEPh7kxlR9obw+bMc7XAfS+xAHUKQYa4jV66qo0wJwO0s76HeiNws2SJ5aoxLMf+DKw==", "11111111113", null, false, null, "db5b750d-a9b1-40d7-9dca-81e17b3a02fe", null, false, "user3@user.user" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "1c4766d9-b8db-4fd6-97a1-7a27410e648a", "user2@user.user", true, "User2", "User2", null, false, null, "USER2@USER.USER", "USER2@USER.USER", "AQAAAAEAACcQAAAAEJV0SE0RCrOOxwZy3LlpY4DGebez20UCQMlzNZatOr+ronmhvT3R1Y/oIIu8AuYGKw==", "11111111112", null, false, null, "d782ddb4-3498-4c3f-8479-ac28295fca1c", null, false, "user2@user.user" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Street", "Town" },
                values: new object[,]
                {
                    { 1, "Karmelicka", "Krakow" },
                    { 2, "Brzozowa", "Warszawa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "48558a02-18a9-48d5-b9d1-9f98c2b6f576");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "a0789143-1f0a-45f6-a9e7-5d4f2ec82f86");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb65ea9-cea9-4951-b794-8967d5bda371", "AQAAAAEAACcQAAAAEPal5xWoTge0/boHIcXpSetTjolxg9cnPyAlsEap4IJWhNUOHT8MfTanyAEw9eJPVg==", "426214ca-8056-4565-a5a0-40ebac0a59f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f50641a-5b1a-4ae6-b7a9-e3ab9760c579", "AQAAAAEAACcQAAAAECTCUGYw8eUGBoFl402NyaBL4QWol0wFV9MEBf9rSmAJ49pHWeSphxECQBhshUqdNQ==", "ec59922c-d6e1-4130-b1c7-a8a8ff220830" });
        }
    }
}
