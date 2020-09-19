using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20200919 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ActionName = table.Column<string>(nullable: true),
                    ActionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevMenuActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    MenuId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevMenuActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevMenus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    MenuCode = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    RoleCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevUserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    Useid = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevUserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Account = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nlogrecs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Application = table.Column<string>(nullable: true),
                    Levels = table.Column<string>(nullable: true),
                    Operatingtime = table.Column<string>(nullable: true),
                    Operatingaddress = table.Column<string>(nullable: true),
                    Userid = table.Column<string>(nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Callsite = table.Column<string>(nullable: true),
                    Requesturl = table.Column<string>(nullable: true),
                    Referrerurl = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
                    LogContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nlogrecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    MenuId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevPermissions_DevRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "DevRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DevActions",
                columns: new[] { "Id", "ActionCode", "ActionName", "CreateDate", "ModifyDate" },
                values: new object[,]
                {
                    { new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), "Query", "查询", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), "Add", "增加", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39579c2f-7f92-4cd0-bf51-76a7a01c8e16"), "Delete", "删除", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("255f3693-099d-432a-9a80-e377976f9c22"), "View", "查看", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DevMenuActions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MenuId", "ModifyDate" },
                values: new object[,]
                {
                    { new Guid("997ef473-3aff-4db5-aec4-4feeefc3c8b6"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("235deae7-b378-488e-bab9-4523a84d620b"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41dbae89-4b0c-4407-b18a-75d702639684"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DevMenus",
                columns: new[] { "Id", "CreateDate", "Icon", "MenuCode", "MenuName", "ModifyDate", "ParentId", "Path" },
                values: new object[,]
                {
                    { new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "People", "人员管理", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), "localhost/people:8080" },
                    { new Guid("a5e189c0-166a-4b37-93ee-45ecf1ff11c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "System", "系统设置", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"), "localhost/system:8080" },
                    { new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "About", "关于", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"), "localhost/about:8080" },
                    { new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/item.ico", "Index", "首页", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("edc8f6c4-d734-49cf-9250-759d966e8641"), "localhost:8080" }
                });

            migrationBuilder.InsertData(
                table: "DevRoles",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "RoleCode", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"), new DateTime(2020, 9, 19, 11, 59, 11, 693, DateTimeKind.Local).AddTicks(7399), new DateTime(2020, 9, 19, 11, 59, 11, 693, DateTimeKind.Local).AddTicks(7423), "SuperAdmin", "超级管理员", 1 },
                    { new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"), new DateTime(2020, 9, 19, 11, 59, 11, 693, DateTimeKind.Local).AddTicks(7489), new DateTime(2020, 9, 19, 11, 59, 11, 693, DateTimeKind.Local).AddTicks(7490), "Admin", "管理员", 1 }
                });

            migrationBuilder.InsertData(
                table: "DevUserRoles",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "RoleId", "Useid" },
                values: new object[] { new Guid("c9372ae7-ebd4-4c4b-9e64-f55965d35e78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"), new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d") });

            migrationBuilder.InsertData(
                table: "DevUsers",
                columns: new[] { "Id", "Account", "Address", "CreateDate", "EMail", "ModifyDate", "Phone", "Pwd", "Status", "UserName" },
                values: new object[] { new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"), "Administrator", null, new DateTime(2020, 9, 19, 11, 59, 11, 692, DateTimeKind.Local).AddTicks(4359), null, new DateTime(2020, 9, 19, 11, 59, 11, 692, DateTimeKind.Local).AddTicks(4680), null, "123456", 1, "超级管理员" });

            migrationBuilder.CreateIndex(
                name: "IX_DevPermissions_RoleId",
                table: "DevPermissions",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevActions");

            migrationBuilder.DropTable(
                name: "DevMenuActions");

            migrationBuilder.DropTable(
                name: "DevMenus");

            migrationBuilder.DropTable(
                name: "DevPermissions");

            migrationBuilder.DropTable(
                name: "DevUserRoles");

            migrationBuilder.DropTable(
                name: "DevUsers");

            migrationBuilder.DropTable(
                name: "Nlogrecs");

            migrationBuilder.DropTable(
                name: "DevRoles");
        }
    }
}
