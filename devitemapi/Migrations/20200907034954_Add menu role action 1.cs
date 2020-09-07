using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace devitemapi.Migrations
{
    public partial class Addmenuroleaction1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevMenus",
                columns: new[] { "Id", "CreateDate", "Icon", "MenuCode", "MenuName", "ModifyDate", "ParentId", "Url" },
                values: new object[] { new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "About", "关于", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "localhost/about:8080" });

            migrationBuilder.InsertData(
                table: "DevPermissions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MemuId", "ModifyDate", "RoleId" },
                values: new object[,]
                {
                    { new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a") },
                    { new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"));

            migrationBuilder.DeleteData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"));

            migrationBuilder.DeleteData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5573), new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5671), new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 443, DateTimeKind.Local).AddTicks(8497), new DateTime(2020, 9, 7, 11, 38, 3, 443, DateTimeKind.Local).AddTicks(9046) });
        }
    }
}