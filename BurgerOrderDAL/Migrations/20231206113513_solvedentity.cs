using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class solvedentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Substances_SubstanceId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_SubstanceId",
                table: "Menus");

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Substances",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DropColumn(
                name: "Domates",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "Ketçap",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "Marul",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "Mayonez",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "Soğan",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "Turşu",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "SubstanceId",
                table: "Menus");

            migrationBuilder.AddColumn<string>(
                name: "MenuId",
                table: "Substances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Substances_Menus_MenuId",
                table: "Substances",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Substances_Menus_MenuId",
                table: "Substances");

            migrationBuilder.DropIndex(
                name: "IX_Substances_MenuId",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Substances");

            migrationBuilder.AddColumn<bool>(
                name: "Domates",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ketçap",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Marul",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mayonez",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Soğan",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Turşu",
                table: "Substances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SubstanceId",
                table: "Menus",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9947));

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

            migrationBuilder.InsertData(
                table: "Substances",
                columns: new[] { "Id", "Created", "DataStatusEnum", "Deleted", "Domates", "Ketçap", "Marul", "Mayonez", "Name", "Soğan", "Turşu", "Updated" },
                values: new object[,]
                {
                    { "1", new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9816), 0, null, true, true, true, false, "WhooperSubstance", false, true, null },
                    { "2", new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9865), 0, null, false, true, false, false, "BigKingSubstance", false, true, null },
                    { "3", new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9893), 0, null, false, true, true, false, "ChikenRoyalSubstance", false, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Created", "SubstanceId" },
                values: new object[] { new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9754), "1" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Created", "SubstanceId" },
                values: new object[] { new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9827), "2" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Created", "SubstanceId" },
                values: new object[] { new DateTime(2023, 12, 6, 13, 18, 58, 943, DateTimeKind.Local).AddTicks(9885), "3" });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SubstanceId",
                table: "Menus",
                column: "SubstanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Substances_SubstanceId",
                table: "Menus",
                column: "SubstanceId",
                principalTable: "Substances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
