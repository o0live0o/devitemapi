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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
                    ModifyUser = table.Column<string>(nullable: true),
                    MenuCode = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true)
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
                    ModifyUser = table.Column<string>(nullable: true),
                    UserCode = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    Account = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
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
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserId = table.Column<int>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserId = table.Column<int>(nullable: false),
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

            migrationBuilder.InsertData(
                table: "WxActions",
                columns: new[] { "Id", "ActionCode", "ActionName", "CreateDate", "CreateUser", "CreateUserId", "ModifyDate", "ModifyUser", "ModifyUserId" },
                values: new object[,]
                {
                    { 1, "view", "查看", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4311), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4315), null, 0 },
                    { 2, "add", "增加", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4708), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4712), null, 0 },
                    { 3, "delete", "删除", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4726), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4727), null, 0 },
                    { 4, "deit", "编辑", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4728), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(4729), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "WxMenus",
                columns: new[] { "Id", "CreateDate", "CreateUser", "CreateUserId", "Icon", "MenuCode", "MenuName", "ModifyDate", "ModifyUser", "ModifyUserId", "OrderNo", "ParentId", "Path" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(2100), null, 0, "el-icon-s-home", "home", "首页", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(2106), null, 0, "000000", 0, "/home" },
                    { 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3777), null, 0, "el-icon-s-tools", "system", "系统管理", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3784), null, 0, "000200", 0, "/system" },
                    { 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3826), null, 0, "el-icon-user-solid", "user", "人员管理", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3827), null, 0, "000201", 2, "/user" },
                    { 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3829), null, 0, "el-icon-s-management", "role", "角色管理", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3834), null, 0, "000202", 2, "/role" },
                    { 5, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3835), null, 0, "el-icon-menu", "menu", "菜单管理", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3836), null, 0, "000203", 2, "/menu" },
                    { 6, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3838), null, 0, "el-icon-info", "about", "关于", new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(3839), null, 0, "000300", 0, "/about" }
                });

            migrationBuilder.InsertData(
                table: "WxRoles",
                columns: new[] { "Id", "CreateDate", "CreateUser", "CreateUserId", "ModifyDate", "ModifyUser", "ModifyUserId", "RoleCode", "RoleName", "Status" },
                values: new object[] { 1, new DateTime(2020, 12, 6, 15, 59, 57, 387, DateTimeKind.Local).AddTicks(9795), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 387, DateTimeKind.Local).AddTicks(9805), null, 0, "SuperAdmin", "超级管理员", 1 });

            migrationBuilder.InsertData(
                table: "WxUsers",
                columns: new[] { "Id", "Account", "Address", "Age", "CreateDate", "CreateUser", "CreateUserId", "EMail", "ModifyDate", "ModifyUser", "ModifyUserId", "Phone", "Pwd", "Sex", "Status", "UserCode", "UserName" },
                values: new object[] { 1, "Administrator", null, 1, new DateTime(2020, 12, 6, 15, 59, 57, 386, DateTimeKind.Local).AddTicks(9314), null, 0, null, new DateTime(2020, 12, 6, 15, 59, 57, 386, DateTimeKind.Local).AddTicks(8594), null, 0, null, "123456", 1, 0, "100001", "超级管理员" });

            migrationBuilder.InsertData(
                table: "WxPermissions",
                columns: new[] { "Id", "ActionId", "CreateDate", "CreateUser", "CreateUserId", "MenuId", "ModifyDate", "ModifyUser", "ModifyUserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5151), null, 0, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5155), null, 0, 1 },
                    { 23, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5819), null, 0, 6, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5820), null, 0, 1 },
                    { 22, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5817), null, 0, 6, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5818), null, 0, 1 },
                    { 21, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5815), null, 0, 6, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5816), null, 0, 1 },
                    { 20, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5813), null, 0, 5, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5814), null, 0, 1 },
                    { 19, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5811), null, 0, 5, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5812), null, 0, 1 },
                    { 18, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5809), null, 0, 5, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5810), null, 0, 1 },
                    { 17, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5807), null, 0, 5, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5808), null, 0, 1 },
                    { 16, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5805), null, 0, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5806), null, 0, 1 },
                    { 15, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5803), null, 0, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5804), null, 0, 1 },
                    { 14, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5801), null, 0, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5802), null, 0, 1 },
                    { 24, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5821), null, 0, 6, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5822), null, 0, 1 },
                    { 13, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5800), null, 0, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5800), null, 0, 1 },
                    { 11, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5796), null, 0, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5796), null, 0, 1 },
                    { 10, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5794), null, 0, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5794), null, 0, 1 },
                    { 9, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5792), null, 0, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5793), null, 0, 1 },
                    { 8, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5790), null, 0, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5791), null, 0, 1 },
                    { 7, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5788), null, 0, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5789), null, 0, 1 },
                    { 6, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5785), null, 0, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5786), null, 0, 1 },
                    { 5, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5783), null, 0, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5784), null, 0, 1 },
                    { 4, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5781), null, 0, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5782), null, 0, 1 },
                    { 3, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5736), null, 0, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5736), null, 0, 1 },
                    { 2, 2, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5705), null, 0, 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5708), null, 0, 1 },
                    { 12, 4, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5798), null, 0, 3, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(5798), null, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "WxUserRoles",
                columns: new[] { "Id", "CreateDate", "CreateUser", "CreateUserId", "ModifyDate", "ModifyUser", "ModifyUserId", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(990), null, 0, new DateTime(2020, 12, 6, 15, 59, 57, 388, DateTimeKind.Local).AddTicks(995), null, 0, 1, 1 });

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
