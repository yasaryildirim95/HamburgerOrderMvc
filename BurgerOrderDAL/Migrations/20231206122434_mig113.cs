using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Substances");

            migrationBuilder.AddColumn<bool>(
                name: "Domates",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ketcap",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Marul",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mayonez",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sogan",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tursu",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Domates",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ketcap",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Marul",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mayonez",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sogan",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tursu",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Created", "Domates", "Marul" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5067), true, true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Created", "Domates", "Tursu" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5144), true, true });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Created", "Domates", "Sogan" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5156), true, true });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5219));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Domates",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Ketcap",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Marul",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Mayonez",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Sogan",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Tursu",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Domates",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Ketcap",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Marul",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Mayonez",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Sogan",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Tursu",
                table: "Menus");

            migrationBuilder.CreateTable(
                name: "Substances",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Substances_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 6, 14, 35, 12, 901, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.CreateIndex(
                name: "IX_Substances_MenuId",
                table: "Substances",
                column: "MenuId");
        }
    }
}
