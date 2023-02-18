using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _25Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

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

            migrationBuilder.AlterColumn<int>(
                name: "PositionModel",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "PositionName" },
                values: new object[,]
                {
                    { 1, "Brak" },
                    { 2, "Front Desk" },
                    { 3, "Chef" },
                    { 4, "Cook" },
                    { 5, "Hotel Manager" },
                    { 6, "Maid" },
                    { 7, "Barista" },
                    { 8, "Waiter" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel",
                principalTable: "Positions",
                principalColumn: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Positions");

            migrationBuilder.AlterColumn<string>(
                name: "PositionName",
                table: "Positions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PositionModel",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionName");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionModel",
                table: "AspNetUsers",
                column: "PositionModel",
                principalTable: "Positions",
                principalColumn: "PositionName");
        }
    }
}
