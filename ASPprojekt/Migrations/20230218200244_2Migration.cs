using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ce2f1f2f-1b88-407a-8545-c06db49e8657");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "1a9fb0b0-3142-4e21-8107-a945d5c9a2d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8137d31e-3972-4a84-a437-6df512510078", "AQAAAAEAACcQAAAAEG+0qoAn8DYA0ZNi1+mcUu7a9xZg9ZRKxCiY1tT/ZzSDcnFHX8CETts/YADkelgjRg==", "702eb4ab-1b10-49d4-b853-ee740eeb6e0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0efd362f-e106-4038-bec6-455f61142497", "AQAAAAEAACcQAAAAECxNTkLcPKyU+DuxNZr/pw97oLzYLG33xQXNHpBP7AXq8wRMqnAxOQqH1LdUNT6L4g==", "07907a0e-5e2c-4547-b1d4-ea1c02002002" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "59d05732-dfe1-4bc1-8098-d92586cc6319");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "45f71dab-5b34-4065-8ea2-b63fedfe7a63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbd057ae-be37-4f74-be18-a4e537df6c72", "AQAAAAEAACcQAAAAEKC/bgZCMt74iEqjRZnZ6nCi9SiObbJ9VGUUBjQOEuaUcpa1uwZr2LdOB+uuODG1BQ==", "8a772696-8acc-4b10-ab10-1ac080df4a2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4840515-83f2-4de4-96eb-f125d2e71585", "AQAAAAEAACcQAAAAEONNtaUm+U5GaQjAUgRrT8pC0feq2KFdS6286yEuJ1mzZC28qCasZj+Z09VH4BCk3Q==", "552c80fd-85c8-4032-81fd-be4d2b926d6f" });
        }
    }
}
