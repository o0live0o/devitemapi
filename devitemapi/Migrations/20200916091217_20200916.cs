using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20200916 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 16, 17, 12, 16, 513, DateTimeKind.Local).AddTicks(5584), new DateTime(2020, 9, 16, 17, 12, 16, 513, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 16, 17, 12, 16, 513, DateTimeKind.Local).AddTicks(5681), new DateTime(2020, 9, 16, 17, 12, 16, 513, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 16, 17, 12, 16, 512, DateTimeKind.Local).AddTicks(2813), new DateTime(2020, 9, 16, 17, 12, 16, 512, DateTimeKind.Local).AddTicks(3153) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 15, 8, 54, 8, 350, DateTimeKind.Local).AddTicks(6816), new DateTime(2020, 9, 15, 8, 54, 8, 350, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 15, 8, 54, 8, 350, DateTimeKind.Local).AddTicks(7088), new DateTime(2020, 9, 15, 8, 54, 8, 350, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 15, 8, 54, 8, 348, DateTimeKind.Local).AddTicks(8054), new DateTime(2020, 9, 15, 8, 54, 8, 348, DateTimeKind.Local).AddTicks(8376) });
        }
    }
}
