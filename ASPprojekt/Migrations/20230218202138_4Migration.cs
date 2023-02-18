using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _4Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASPprojektUserPlanModel");

            migrationBuilder.AddColumn<string>(
                name: "ASPprojektUserId",
                table: "PlanModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_PlanModels_ASPprojektUserId",
                table: "PlanModels",
                column: "ASPprojektUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanModels_AspNetUsers_ASPprojektUserId",
                table: "PlanModels",
                column: "ASPprojektUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
    }
}
