using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _2020090801 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevPermissions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MemuId", "ModifyDate", "RoleId" },
                values: new object[,]
                {
                    { new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a") },
                    { new Guid("3e41c160-9781-4818-afb5-3d33455ab754"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a") }
                });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4000), new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4084), new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 220, DateTimeKind.Local).AddTicks(8689), new DateTime(2020, 9, 8, 9, 30, 42, 220, DateTimeKind.Local).AddTicks(9199) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e41c160-9781-4818-afb5-3d33455ab754"));

            migrationBuilder.DeleteData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 21, 22, 812, DateTimeKind.Local).AddTicks(7923), new DateTime(2020, 9, 8, 9, 21, 22, 812, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 21, 22, 812, DateTimeKind.Local).AddTicks(8021), new DateTime(2020, 9, 8, 9, 21, 22, 812, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 21, 22, 810, DateTimeKind.Local).AddTicks(8690), new DateTime(2020, 9, 8, 9, 21, 22, 810, DateTimeKind.Local).AddTicks(9222) });
        }
    }
}
