using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _2020090803 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevMenuActions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MenuId", "ModifyDate" },
                values: new object[] { new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 10, 1, 28, 477, DateTimeKind.Local).AddTicks(3765), new DateTime(2020, 9, 8, 10, 1, 28, 477, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 10, 1, 28, 477, DateTimeKind.Local).AddTicks(3853), new DateTime(2020, 9, 8, 10, 1, 28, 477, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 10, 1, 28, 475, DateTimeKind.Local).AddTicks(7481), new DateTime(2020, 9, 8, 10, 1, 28, 475, DateTimeKind.Local).AddTicks(7982) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7321), new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7421), new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 795, DateTimeKind.Local).AddTicks(9032), new DateTime(2020, 9, 8, 9, 58, 57, 795, DateTimeKind.Local).AddTicks(9571) });
        }
    }
}
