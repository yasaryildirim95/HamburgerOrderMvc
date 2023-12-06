using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Extras",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "MenuId", "Name", "OrderId", "Price", "Updated" },
                values: new object[] { "1", new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9947), 0, null, null, "Ranch Sos", null, 10, null });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.CreateIndex(
                name: "IX_Extras_OrderId",
                table: "Extras",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Orders_OrderId",
                table: "Extras",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Orders_OrderId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_OrderId",
                table: "Extras");

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Extras");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7915));
        }
    }
}
