using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _2020103001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Golds");

            migrationBuilder.CreateTable(
                name: "GoldDailyPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsignmentId = table.Column<string>(nullable: true),
                    ZoneId = table.Column<string>(nullable: true),
                    ZoneName = table.Column<string>(nullable: true),
                    ServerId = table.Column<string>(nullable: true),
                    ServerName = table.Column<string>(nullable: true),
                    SellerRoleName = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    GoldAmount = table.Column<decimal>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    GainTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldDailyPrice", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("255f3693-099d-432a-9a80-e377976f9c22"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(556), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(550), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(499), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(6839), new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("235deae7-b378-488e-bab9-4523a84d620b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4580), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("41dbae89-4b0c-4407-b18a-75d702639684"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4520), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4587), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4572), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4594), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(2033), new DateTime(2020, 10, 30, 13, 43, 24, 958, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(9097), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5300), new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5293), new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5237), new DateTime(2020, 10, 30, 13, 43, 24, 957, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6585), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e41c160-9781-4818-afb5-3d33455ab754"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6786), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(1569), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6640), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6650), new DateTime(2020, 10, 30, 13, 43, 24, 956, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(7190), new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(7283), new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "DevUserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(8138), new DateTime(2020, 10, 30, 13, 43, 24, 955, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 13, 43, 24, 953, DateTimeKind.Local).AddTicks(8758), new DateTime(2020, 10, 30, 13, 43, 24, 953, DateTimeKind.Local).AddTicks(9634) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoldDailyPrice");

            migrationBuilder.CreateTable(
                name: "Golds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsignmentId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    GainTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GoldAmount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Remark = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SellerRoleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ServerId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ServerName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ZoneId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ZoneName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golds", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("255f3693-099d-432a-9a80-e377976f9c22"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6913), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6908), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6878), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "DevActions",
                keyColumn: "Id",
                keyValue: new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5951), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("235deae7-b378-488e-bab9-4523a84d620b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8765), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("41dbae89-4b0c-4407-b18a-75d702639684"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8725), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8771), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8757), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8777), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(7655), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("19b93b25-5230-425b-b5c5-625b708915b5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(2757), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5184), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5177), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "DevMenus",
                keyColumn: "Id",
                keyValue: new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5110), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("028d9d91-2f5f-4503-803c-8296c4bae426"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1656), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3e41c160-9781-4818-afb5-3d33455ab754"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1714), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(9938), new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e55c31ba-e4fc-4682-a4ad-b5eee06d2b3b"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1698), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "DevPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f93a453e-a93d-4314-803d-fe586c119bcd"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1706), new DateTime(2020, 10, 30, 10, 7, 36, 39, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(6794), new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(6881), new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "DevUserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(7690), new DateTime(2020, 10, 30, 10, 7, 36, 38, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 10, 30, 10, 7, 36, 36, DateTimeKind.Local).AddTicks(6995), new DateTime(2020, 10, 30, 10, 7, 36, 36, DateTimeKind.Local).AddTicks(7569) });
        }
    }
}
