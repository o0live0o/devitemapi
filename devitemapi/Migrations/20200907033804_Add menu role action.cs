using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace devitemapi.Migrations
{
    public partial class Addmenuroleaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevRolePermissions");

            migrationBuilder.AlterColumn<Guid>(
                name: "Useid",
                table: "DevUserRoles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoleId",
                table: "DevUserRoles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "RoleCode",
                table: "DevRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MenuCode",
                table: "DevMenus",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                table: "DevMenuActions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ActionId",
                table: "DevMenuActions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DevPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    MemuId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevPermissions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DevActions",
                columns: new[] { "Id", "ActionCode", "ActionName", "CreateDate", "ModifyDate" },
                values: new object[,]
                {
                    { new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), "Query", "查询", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), "Add", "增加", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"), "Delete", "删除", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DevMenus",
                columns: new[] { "Id", "CreateDate", "Icon", "MenuCode", "MenuName", "ModifyDate", "ParentId", "Url" },
                values: new object[] { new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "Index", "首页", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "localhost:8080" });

            migrationBuilder.InsertData(
                table: "DevPermissions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MemuId", "ModifyDate", "RoleId" },
                values: new object[] { new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a") });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate", "RoleCode" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5573), new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5602), "SuperAdmin" });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate", "RoleCode" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5671), new DateTime(2020, 9, 7, 11, 38, 3, 445, DateTimeKind.Local).AddTicks(5672), "Admin" });

            migrationBuilder.InsertData(
                table: "DevUserRoles",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "RoleId", "Useid" },
                values: new object[] { new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"), new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d") });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 7, 11, 38, 3, 443, DateTimeKind.Local).AddTicks(8497), new DateTime(2020, 9, 7, 11, 38, 3, 443, DateTimeKind.Local).AddTicks(9046) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevPermissions");

            migrationBuilder.DeleteData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"));

            migrationBuilder.DeleteData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"));

            migrationBuilder.DeleteData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"));

            migrationBuilder.DeleteData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"));

            migrationBuilder.DeleteData(
                table: "DevUserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"));

            migrationBuilder.DropColumn(
                name: "RoleCode",
                table: "DevRoles");

            migrationBuilder.DropColumn(
                name: "MenuCode",
                table: "DevMenus");

            migrationBuilder.AlterColumn<int>(
                name: "Useid",
                table: "DevUserRoles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "DevUserRoles",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "MenuId",
                table: "DevMenuActions",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<int>(
                name: "ActionId",
                table: "DevMenuActions",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateTable(
                name: "DevRolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MemuId = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevRolePermissions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 15, 10, 1, 772, DateTimeKind.Local).AddTicks(8306), new DateTime(2020, 8, 21, 15, 10, 1, 772, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 15, 10, 1, 772, DateTimeKind.Local).AddTicks(8386), new DateTime(2020, 8, 21, 15, 10, 1, 772, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 15, 10, 1, 770, DateTimeKind.Local).AddTicks(8194), new DateTime(2020, 8, 21, 15, 10, 1, 770, DateTimeKind.Local).AddTicks(9128) });
        }
    }
}