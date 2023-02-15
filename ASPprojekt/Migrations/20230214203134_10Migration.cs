using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _10Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ASPprojektUserPositionModel_Positions_PositionId",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPprojektUserPositionModel",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PositionName",
                table: "ASPprojektUserPositionModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPprojektUserPositionModel",
                table: "ASPprojektUserPositionModel",
                columns: new[] { "PositionName", "UsersId" });

            migrationBuilder.InsertData(
                table: "Positions",
                column: "PositionName",
                value: "Brak");

            migrationBuilder.AddForeignKey(
                name: "FK_ASPprojektUserPositionModel_Positions_PositionName",
                table: "ASPprojektUserPositionModel",
                column: "PositionName",
                principalTable: "Positions",
                principalColumn: "PositionName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ASPprojektUserPositionModel_Positions_PositionName",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPprojektUserPositionModel",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Barista");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Brak");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Chef");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Cook");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Front Desk");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Hotel Manager");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Maid");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionName",
                keyValue: "Waiter");

            migrationBuilder.DropColumn(
                name: "PositionName",
                table: "ASPprojektUserPositionModel");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "ASPprojektUserPositionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPprojektUserPositionModel",
                table: "ASPprojektUserPositionModel",
                columns: new[] { "PositionId", "UsersId" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "PositionName" },
                values: new object[,]
                {
                    { 1, "Front Desk" },
                    { 2, "Chef" },
                    { 3, "Cook" },
                    { 4, "Hotel Manager" },
                    { 5, "Maid" },
                    { 6, "Barista" },
                    { 7, "Waiter" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ASPprojektUserPositionModel_Positions_PositionId",
                table: "ASPprojektUserPositionModel",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
