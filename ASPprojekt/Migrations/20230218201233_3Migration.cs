using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _3Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ASPprojektUserPlanModel",
                columns: table => new
                {
                    ASPprojektUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPprojektUserPlanModel", x => new { x.ASPprojektUserId, x.PlanModelId });
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPlanModel_AspNetUsers_ASPprojektUserId",
                        column: x => x.ASPprojektUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASPprojektUserPlanModel_PlanModels_PlanModelId",
                        column: x => x.PlanModelId,
                        principalTable: "PlanModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "63490be4-0100-4c65-aee8-04caae322b2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "1e937cef-cd87-4879-baa3-8c0d6e0e7f0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ca64bac-67b6-4e06-a73f-d63ee4f5541a", "AQAAAAEAACcQAAAAEKQkk2X3y2I1JVk0f0gSUi4o4sYIr2Mk7BeaGBBj0DQsUn8nsF6HYRYqXxg5Gd/FYg==", "3faef96a-f67f-43bc-98ec-ae1722043972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "158afaf2-859b-4256-9480-bc5022bc265a", "AQAAAAEAACcQAAAAEG0JWZp8JAPk4fwOlSNo0ldo2HlbsHmkXdJDC+dvBMgr2kfkew6V+nLmm/cG4FLfLg==", "8cc26023-01c4-4caa-b884-2b885d72708a" });

            migrationBuilder.CreateIndex(
                name: "IX_ASPprojektUserPlanModel_PlanModelId",
                table: "ASPprojektUserPlanModel",
                column: "PlanModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASPprojektUserPlanModel");

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
    }
}
