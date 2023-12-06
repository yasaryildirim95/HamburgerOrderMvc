using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Menus_MenuId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_Substances_Menus_MenuId",
                table: "Substances");

            migrationBuilder.DropIndex(
                name: "IX_Substances_MenuId",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Substances");

            migrationBuilder.RenameColumn(
                name: "MenuSize",
                table: "Orders",
                newName: "Amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProductSizeId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SubstanceId",
                table: "Menus",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                table: "Extras",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "Name", "PriceMultiplier", "Updated" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7930), 0, null, "Small", 0.9m, null },
                    { "2", new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7943), 0, null, "Medium", 1m, null },
                    { "3", new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(7994), 0, null, "Large", 1.2m, null },
                    { "4", new DateTime(2023, 12, 6, 12, 20, 38, 377, DateTimeKind.Local).AddTicks(8005), 0, null, "Mega", 1.5m, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductSizeId",
                table: "Orders",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SubstanceId",
                table: "Menus",
                column: "SubstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Menus_MenuId",
                table: "Extras",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Substances_SubstanceId",
                table: "Menus",
                column: "SubstanceId",
                principalTable: "Substances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ProductSize_ProductSizeId",
                table: "Orders",
                column: "ProductSizeId",
                principalTable: "ProductSize",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Menus_MenuId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Substances_SubstanceId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ProductSize_ProductSizeId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductSizeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Menus_SubstanceId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ProductSizeId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Orders",
                newName: "MenuSize");

            migrationBuilder.AddColumn<string>(
                name: "MenuId",
                table: "Substances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "SubstanceId",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                table: "Extras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Created", "MenuId" },
                values: new object[] { new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6960), "1" });

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Created", "MenuId" },
                values: new object[] { new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6980), "2" });

            migrationBuilder.UpdateData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Created", "MenuId" },
                values: new object[] { new DateTime(2023, 12, 5, 18, 2, 10, 800, DateTimeKind.Local).AddTicks(6996), "3" });

            migrationBuilder.CreateIndex(
                name: "IX_Substances_MenuId",
                table: "Substances",
                column: "MenuId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Menus_MenuId",
                table: "Extras",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Substances_Menus_MenuId",
                table: "Substances",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
