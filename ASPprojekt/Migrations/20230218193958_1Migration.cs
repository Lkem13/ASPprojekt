using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _1Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ASPprojektUserId",
                table: "PlanModels",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PlanModels_ASPprojektUserId",
                table: "PlanModels",
                column: "ASPprojektUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanModels_AspNetUsers_ASPprojektUserId",
                table: "PlanModels",
                column: "ASPprojektUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanModels_AspNetUsers_ASPprojektUserId",
                table: "PlanModels");

            migrationBuilder.DropIndex(
                name: "IX_PlanModels_ASPprojektUserId",
                table: "PlanModels");

            migrationBuilder.DropColumn(
                name: "ASPprojektUserId",
                table: "PlanModels");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "00efd9c4-8bec-432c-bc7d-072ed2913221");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "2e10ce50-1483-4290-87f3-1372123f95d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77f10b04-0927-4588-8349-16accbda47a9", "AQAAAAEAACcQAAAAEFhOd78+LPwPPBQXOdCOCLG+JcrpSIvnTkV73DUOXRDylJaDrj84RPo8WVQD+ptbFA==", "fa109482-1c9b-4773-8790-e3e213909497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccab831c-98c2-4d76-91f2-9bc69de3a6fb", "AQAAAAEAACcQAAAAELH6JZ8C9XWH0WFd1TBocUOX9O4OvP5ldHStcLOi6OPS76zkolGsdwjMnWbNXMh4PQ==", "ab534e53-cb85-4452-8d33-770339c2f8ec" });
        }
    }
}
