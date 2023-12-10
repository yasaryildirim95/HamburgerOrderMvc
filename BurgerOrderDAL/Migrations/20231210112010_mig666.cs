using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerOrderDAL.Migrations
{
    public partial class mig666 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79901907-1862-463c-8513-184d6322e984");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b5184c4-13c4-4ec7-be5b-184d7b99e70a", "461c9a2d-3d57-49e1-a7b6-10e698229b1a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b5184c4-13c4-4ec7-be5b-184d7b99e70a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "461c9a2d-3d57-49e1-a7b6-10e698229b1a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Created", "DataStatusEnum", "Deleted", "Name", "NormalizedName", "Updated" },
                values: new object[,]
                {
                    { "2561886e-88c2-404e-b70b-a003197b4bc8", "ee089133-63fc-48af-ae2b-2c80b1bf669f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "User", null, null },
                    { "bcfca20a-0a81-4c75-ba26-055c4bd73525", "7789b376-70c5-46df-a7a7-09098f4e2fa9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "DataStatusEnum", "Deleted", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "e652152d-f386-46f5-8862-e0809fa8f47a", 0, "e85833dd-8afc-4eba-86ad-6d1c5f05fe13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "admin@hotmail.com", false, false, null, "Admin", "ADMIN@HOTMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAECTE0fXVYcKBR75erPXssJYR/fK/+9IvcLmFX9DsATeqJBMElUPQGHkNBcxxjil2eQ==", null, false, "8f29864f-b4c6-477b-a5d5-884a19f042d7", "Admin", false, null, "Admin" });

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 10, 14, 20, 10, 505, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bcfca20a-0a81-4c75-ba26-055c4bd73525", "e652152d-f386-46f5-8862-e0809fa8f47a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2561886e-88c2-404e-b70b-a003197b4bc8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcfca20a-0a81-4c75-ba26-055c4bd73525", "e652152d-f386-46f5-8862-e0809fa8f47a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcfca20a-0a81-4c75-ba26-055c4bd73525");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e652152d-f386-46f5-8862-e0809fa8f47a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Created", "DataStatusEnum", "Deleted", "Name", "NormalizedName", "Updated" },
                values: new object[,]
                {
                    { "79901907-1862-463c-8513-184d6322e984", "9dc30439-6b0b-4e52-b2cd-35bb146342c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "User", null, null },
                    { "7b5184c4-13c4-4ec7-be5b-184d7b99e70a", "51215c3b-32c5-421d-bd86-43ca454c44b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "Admin", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "DataStatusEnum", "Deleted", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[] { "461c9a2d-3d57-49e1-a7b6-10e698229b1a", 0, "a6136d56-572c-402f-b63d-256373196227", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "admin@hotmail.com", false, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEFUfQPU95XrAkhC/g/PfjMcU9S8xTJbqSI33JRtoB7g1Pv62VgsWKSVUlt+/8SPNPQ==", null, false, "a6a23966-d1b8-4a3f-9b91-3ee39636b5a2", "Admin", false, null, "Admin" });

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Extra",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 421, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 12, 9, 21, 58, 39, 420, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7b5184c4-13c4-4ec7-be5b-184d7b99e70a", "461c9a2d-3d57-49e1-a7b6-10e698229b1a" });
        }
    }
}
