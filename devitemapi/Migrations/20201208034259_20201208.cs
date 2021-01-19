using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20201208 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "WxUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "WxUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "WxUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(8304), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9251), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9275), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9278), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(4179), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7224), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7291), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7296), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7299), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7302), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(74), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1453), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1561), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1565), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1568), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1571), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1574), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1576), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1579), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1582), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1585), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1588), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1590), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1593), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1596), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1598), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1601), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1604), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1607), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1610), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1613), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1616), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1618), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1621), new DateTime(2020, 12, 8, 11, 42, 59, 255, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "WxRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 253, DateTimeKind.Local).AddTicks(8770), new DateTime(2020, 12, 8, 11, 42, 59, 253, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "WxUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(1725), new DateTime(2020, 12, 8, 11, 42, 59, 254, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "WxUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 8, 11, 42, 59, 251, DateTimeKind.Local).AddTicks(7744), new DateTime(2020, 12, 8, 11, 42, 59, 251, DateTimeKind.Local).AddTicks(5455) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "WxUsers");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "WxUsers");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "WxUsers");

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4311), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4708), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4726), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "WxActions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4728), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(2100), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3777), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3826), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3829), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3835), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "WxMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3838), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5151), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5705), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5736), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5781), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5783), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5785), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5788), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5790), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5792), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5794), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5796), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5798), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5800), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5801), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5803), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5805), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5807), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5809), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5811), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5813), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5815), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5817), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5819), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "WxPermissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5821), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "WxRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 387, DateTimeKind.Local).AddTicks(9795), new DateTime(2020, 12, 6, 15, 59, 57, 387, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "WxUserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(990), new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "WxUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 12, 6, 15, 59, 57, 386, DateTimeKind.Local).AddTicks(9314), new DateTime(2020, 12, 6, 15, 59, 57, 386, DateTimeKind.Local).AddTicks(8594) });
        }
    }
}
