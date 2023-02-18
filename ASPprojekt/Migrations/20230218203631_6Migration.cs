using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _6Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "53a37830-3b24-44d8-b066-b9018e21e0c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "3d968e1e-cf78-48f4-ab24-2306f074075d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f99d409-297b-4336-9858-31381984bca7", "AQAAAAEAACcQAAAAEHKtWXdax8oV1NSzq2mmDXjlqMloWRRQ6jsvyyTOhk7/09GtIWuaGe+C7JWogPaV7g==", "691cfb03-3cb2-4383-a09c-d8e9ee97fc0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84987c7e-564c-449e-ba79-618681740188", "AQAAAAEAACcQAAAAELXt5dZTRn0uuB9KsVEVjwtGveiuqGzdZ/bBm2PRd/noWaHE0OhGX3MkJtYz+PgNQQ==", "89473398-6fa2-482b-a911-feeac2a764da" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
