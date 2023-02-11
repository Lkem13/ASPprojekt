using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPprojekt.Migrations
{
    public partial class _2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationForeignKey",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationModelLocationId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pesel",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionForeignKey",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionModelPositionId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusForeignKey",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusModelStatusId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeForeignKey",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeModelTypeId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LocationModel",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationModel", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "PositionModel",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionModel", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "StatusModel",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusModel", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TypeModel",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeModel", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationModelLocationId",
                table: "AspNetUsers",
                column: "LocationModelLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PositionModelPositionId",
                table: "AspNetUsers",
                column: "PositionModelPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StatusModelStatusId",
                table: "AspNetUsers",
                column: "StatusModelStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TypeModelTypeId",
                table: "AspNetUsers",
                column: "TypeModelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationModelLocationId",
                table: "AspNetUsers",
                column: "LocationModelLocationId",
                principalTable: "LocationModel",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionModelPositionId",
                table: "AspNetUsers",
                column: "PositionModelPositionId",
                principalTable: "PositionModel",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusModelStatusId",
                table: "AspNetUsers",
                column: "StatusModelStatusId",
                principalTable: "StatusModel",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TypeModel_TypeModelTypeId",
                table: "AspNetUsers",
                column: "TypeModelTypeId",
                principalTable: "TypeModel",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_LocationModel_LocationModelLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PositionModel_PositionModelPositionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StatusModel_StatusModelStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TypeModel_TypeModelTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LocationModel");

            migrationBuilder.DropTable(
                name: "PositionModel");

            migrationBuilder.DropTable(
                name: "StatusModel");

            migrationBuilder.DropTable(
                name: "TypeModel");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LocationModelLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PositionModelPositionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StatusModelStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TypeModelTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationForeignKey",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LocationModelLocationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionForeignKey",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionModelPositionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatusForeignKey",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatusModelStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TypeForeignKey",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TypeModelTypeId",
                table: "AspNetUsers");
        }
    }
}
