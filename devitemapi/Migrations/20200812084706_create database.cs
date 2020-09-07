using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace devitemapi.Migrations
{
    public partial class createdatabase : Migration
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
                    MenuId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
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
                    MenuName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevRolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    MemuId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevRolePermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
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
                    Useid = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "DevRoles",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "RoleName", "Status" },
                values: new object[] { new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4175), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4217), "超级管理员", 1 });

            migrationBuilder.InsertData(
                table: "DevRoles",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "RoleName", "Status" },
                values: new object[] { new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4293), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4295), "管理员", 1 });

            migrationBuilder.InsertData(
                table: "DevUsers",
                columns: new[] { "Id", "Account", "Address", "CreateDate", "EMail", "ModifyDate", "Phone", "Pwd", "Status", "UserName" },
                values: new object[] { new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"), "Administrator", null, new DateTime(2020, 8, 12, 16, 47, 6, 81, DateTimeKind.Local).AddTicks(7769), null, new DateTime(2020, 8, 12, 16, 47, 6, 82, DateTimeKind.Local).AddTicks(8069), null, "123456", 1, "超级管理员" });
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
                name: "DevRolePermissions");

            migrationBuilder.DropTable(
                name: "DevRoles");

            migrationBuilder.DropTable(
                name: "DevUserRoles");

            migrationBuilder.DropTable(
                name: "DevUsers");
        }
    }
}