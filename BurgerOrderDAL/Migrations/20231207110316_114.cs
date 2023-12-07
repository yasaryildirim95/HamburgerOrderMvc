using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class _114 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 14, 3, 15, 945, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "MenuId", "Name", "OrderId", "Price", "Updated" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "3");

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
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 15, 24, 33, 920, DateTimeKind.Local).AddTicks(5156));

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
    }
}
