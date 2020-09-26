using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20200926 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevPermissions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevPermissions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevPermissions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevPermissions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevMenus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevMenus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevMenus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevMenus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevMenuActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevMenuActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevMenuActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevMenuActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUser",
                table: "DevActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateUserId",
                table: "DevActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUser",
                table: "DevActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifyUserId",
                table: "DevActions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("255f3693-099d-432a-9a80-e377976f9c22"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4852), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4847), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4816), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(2856), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("235deae7-b378-488e-bab9-4523a84d620b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9237), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("41dbae89-4b0c-4407-b18a-75d702639684"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9003), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9246), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9228), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9253), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(6837), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(5699), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(1129), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(1119), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(918), new DateTime(2020, 9, 26, 11, 32, 22, 72, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4612), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e41c160-9781-4818-afb5-3d33455ab754"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4673), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(3077), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4658), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4666), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(246), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(339), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "DevUserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(1154), new DateTime(2020, 9, 26, 11, 32, 22, 71, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 26, 11, 32, 22, 69, DateTimeKind.Local).AddTicks(861), new DateTime(2020, 9, 26, 11, 32, 22, 69, DateTimeKind.Local).AddTicks(1428) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevUsers");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevUsers");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevUsers");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevUsers");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevUserRoles");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevUserRoles");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevUserRoles");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevRoles");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevRoles");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevRoles");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevRoles");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevPermissions");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevPermissions");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevPermissions");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevPermissions");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevMenus");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevMenus");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevMenus");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevMenus");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevMenuActions");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevMenuActions");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevMenuActions");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevMenuActions");

            migrationBuilder.DropColumn(
                name: "CreateUser",
                table: "DevActions");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "DevActions");

            migrationBuilder.DropColumn(
                name: "ModifyUser",
                table: "DevActions");

            migrationBuilder.DropColumn(
                name: "ModifyUserId",
                table: "DevActions");

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("255f3693-099d-432a-9a80-e377976f9c22"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("235deae7-b378-488e-bab9-4523a84d620b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("41dbae89-4b0c-4407-b18a-75d702639684"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e41c160-9781-4818-afb5-3d33455ab754"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 16, 45, 30, 0, DateTimeKind.Local).AddTicks(7649), new DateTime(2020, 9, 21, 16, 45, 30, 0, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 16, 45, 30, 0, DateTimeKind.Local).AddTicks(7747), new DateTime(2020, 9, 21, 16, 45, 30, 0, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "DevUserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 16, 45, 29, 999, DateTimeKind.Local).AddTicks(3976), new DateTime(2020, 9, 21, 16, 45, 29, 999, DateTimeKind.Local).AddTicks(4486) });
        }
    }
}
