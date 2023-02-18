using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _5Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0bcaca7d-708c-4021-9645-51aff9a62942");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "eb0719a2-c155-446d-a264-a6d789e5b094");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20c62a60-5c4e-4e78-8c8f-e1270c2b2bf9", "AQAAAAEAACcQAAAAEOi65RUnw+EZq4OVkJZZEyMBmKuYW5DA9XlzHUBZe7bGNKb0RrVbsWY2aCzkNhloaw==", "433a7756-f62d-4284-9ab1-db644026bcc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05b77ca5-cd36-40df-809a-8433efb49bff", "AQAAAAEAACcQAAAAEAcS/bD9sjeyoyz+FmlQx00VVIwC/8zQlX+Chq8KcXOqUDF4vUQLIq1Voif4eqf3iQ==", "d8cbdf22-00d6-4ad8-bbb0-5dadbf5e6a80" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "67a709df-ca54-47ee-a269-3e592d391cb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "9b84f14f-b1b0-42d6-9fb0-fe9e9a9280f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d1a1951-9665-41d7-8b3f-6b1afb7b03bb", "AQAAAAEAACcQAAAAEKlouezfwY/QkBgQTQZDiaUWA62ugJZkSKKkYLQYeEqGSgiLTBIpmV7+W2GIxo0ehQ==", "dcb7c8f5-9e9b-41dd-9f19-b10f07290992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f083e86-b5b0-4449-a94e-5cafd89b0248", "AQAAAAEAACcQAAAAEAK/x1pMKmgnCkEMEzZgWCNaAk6KTkk8lD7mlHIjejmNOnRDzFQqVEpfavcn+a5oOw==", "ae7f51ae-6d87-4604-ad50-521f2935a61f" });
        }
    }
}
