using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _20200920 : Migration
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
