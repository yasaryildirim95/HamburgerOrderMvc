using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.CreateTable(
                name: "Extra",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Extra",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "Name", "Price", "Updated" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 12, 7, 22, 44, 50, 589, DateTimeKind.Local).AddTicks(1594), 0, null, "Ranch Sos", 10, null },
                    { "2", new DateTime(2023, 12, 7, 22, 44, 50, 589, DateTimeKind.Local).AddTicks(1628), 0, null, "Barbekü Sos", 10, null },
                    { "3", new DateTime(2023, 12, 7, 22, 44, 50, 589, DateTimeKind.Local).AddTicks(1638), 0, null, "Ballı Hardal Sos", 10, null }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 7, 22, 44, 50, 588, DateTimeKind.Local).AddTicks(7684));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extra");

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MenuId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extras_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Extras_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "MenuId", "Name", "OrderId", "Price", "Updated" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2402), 0, null, null, "Ranch Sos", null, 10, null },
                    { "2", new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2410), 0, null, null, "Barbekü Sos", null, 10, null },
                    { "3", new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2417), 0, null, null, "Ballı Hardal Sos", null, 10, null }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.CreateIndex(
                name: "IX_Extras_MenuId",
                table: "Extras",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_OrderId",
                table: "Extras",
                column: "OrderId");
        }
    }
}
