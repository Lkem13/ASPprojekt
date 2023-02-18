using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _28Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0bb0b26d-61d2-4d20-b705-7722eb36748b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "5c7023de-b4fd-40af-9cf6-fc157a5df0ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efcfac36-037d-4269-a241-23d12a7d3202", "AQAAAAEAACcQAAAAEDWTUYhKIYGdsmZWyBUdQBF54Fyk5Y5rIaq7qaerskN468AiOnKBymM0xcS6Ml/X3A==", "a4d44482-bc24-4be5-97dd-801cfd230818" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a720b0bf-5488-41db-be10-3614383357fd", "AQAAAAEAACcQAAAAEFNkXUJTrgp50fHNf8QK5zoQUxiEVYzlFsxpLvyY0gXtu2NjykZihd6WRFH9ox57Yg==", "7b7eeffb-653c-44b5-b0f1-4874397ec5a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "23bc491a-8a66-4b02-89b4-d5af23e8bc9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "484a8207-f23e-45e1-8fab-c9eef6d3a3f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20649e08-3513-4f16-8b0e-d2a154a782ce", "AQAAAAEAACcQAAAAEPkz5mBNe0OYbO3ePzj1WpAIrW9yCqv+SiJRgR6UbCJfUqY4UVo5SHhiZY0IWPz5cQ==", "51c93181-1cb6-43fe-9768-a68e111faf4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87223ac7-0962-495b-bada-89683d9fe98c", "AQAAAAEAACcQAAAAEBhyy389mj+G6R+UeDfItS1IfMKWJ5/JCWdSrUtYoAc5e8LH2nwxRERMIlx9rjPQqw==", "b3176684-1b4f-4195-abad-fdd43e9357d6" });
        }
    }
}
