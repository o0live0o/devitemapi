using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20200908 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "DevMenus",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                column: "ParentId",
                value: new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"));

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                column: "ParentId",
                value: new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"));

            migrationBuilder.InsertData(
                table: "DevMenus",
                columns: new[] { "Id", "CreateDate", "Icon", "MenuCode", "MenuName", "ModifyDate", "ParentId", "Url" },
                values: new object[,]
                {
                    { new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "System", "系统设置", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"), "localhost/system:8080" },
                    { new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "People", "人员管理", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), "localhost/people:8080" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"));

            migrationBuilder.DeleteData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"));

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "DevMenus",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                column: "ParentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                column: "ParentId",
                value: 0);

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
    }
}
