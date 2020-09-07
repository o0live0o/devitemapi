using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace devitemapi.Migrations
{
    public partial class Addmenuroleaction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                column: "MemuId",
                value: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 51, 56, 906, DateTimeKind.Local).AddTicks(3753), new DateTime(2020, 9, 7, 11, 51, 56, 906, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 51, 56, 906, DateTimeKind.Local).AddTicks(3842), new DateTime(2020, 9, 7, 11, 51, 56, 906, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 51, 56, 904, DateTimeKind.Local).AddTicks(7591), new DateTime(2020, 9, 7, 11, 51, 56, 904, DateTimeKind.Local).AddTicks(8124) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                column: "MemuId",
                value: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 49, 54, 488, DateTimeKind.Local).AddTicks(196), new DateTime(2020, 9, 7, 11, 49, 54, 488, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 49, 54, 488, DateTimeKind.Local).AddTicks(281), new DateTime(2020, 9, 7, 11, 49, 54, 488, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 49, 54, 486, DateTimeKind.Local).AddTicks(4973), new DateTime(2020, 9, 7, 11, 49, 54, 486, DateTimeKind.Local).AddTicks(5506) });
        }
    }
}