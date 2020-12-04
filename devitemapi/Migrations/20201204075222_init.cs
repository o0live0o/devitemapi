using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WxActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    ActionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxGoldDailyPrice",
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
                    table.PrimaryKey("PK_WxGoldDailyPrice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    MenuCode = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxNlogrecs",
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
                    table.PrimaryKey("PK_WxNlogrecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    RoleName = table.Column<string>(nullable: true),
                    RoleCode = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    UserCode = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    Account = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WxMenuActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    MenuId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxMenuActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WxMenuActions_WxMenus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "WxMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WxPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WxPermissions_WxRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "WxRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WxUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(nullable: true),
                    ModifyUser = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WxUserRoles_WxUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "WxUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WxMenuActions_MenuId",
                table: "WxMenuActions",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_WxPermissions_RoleId",
                table: "WxPermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WxUserRoles_UserId",
                table: "WxUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WxUsers_UserCode",
                table: "WxUsers",
                column: "UserCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WxActions");

            migrationBuilder.DropTable(
                name: "WxGoldDailyPrice");

            migrationBuilder.DropTable(
                name: "WxMenuActions");

            migrationBuilder.DropTable(
                name: "WxNlogrecs");

            migrationBuilder.DropTable(
                name: "WxPermissions");

            migrationBuilder.DropTable(
                name: "WxUserRoles");

            migrationBuilder.DropTable(
                name: "WxMenus");

            migrationBuilder.DropTable(
                name: "WxRoles");

            migrationBuilder.DropTable(
                name: "WxUsers");
        }
    }
}
