using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 7, 15, 22, 53, 364, DateTimeKind.Local).AddTicks(9925));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
