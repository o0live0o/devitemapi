using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _2020092101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Useid",
                table: "DevUserRoles",
                newName: "UseId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "DevUserRoles",
                nullable: true);

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
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 16, 45, 29, 999, DateTimeKind.Local).AddTicks(3976), new DateTime(2020, 9, 21, 16, 45, 29, 999, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.CreateIndex(
                name: "IX_DevUserRoles_UserId",
                table: "DevUserRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevUserRoles_DevUsers_UserId",
                table: "DevUserRoles",
                column: "UserId",
                principalTable: "DevUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevUserRoles_DevUsers_UserId",
                table: "DevUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_DevUserRoles_UserId",
                table: "DevUserRoles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DevUserRoles");

            migrationBuilder.RenameColumn(
                name: "UseId",
                table: "DevUserRoles",
                newName: "Useid");

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 14, 13, 34, 500, DateTimeKind.Local).AddTicks(3452), new DateTime(2020, 9, 21, 14, 13, 34, 500, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 14, 13, 34, 500, DateTimeKind.Local).AddTicks(3536), new DateTime(2020, 9, 21, 14, 13, 34, 500, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 21, 14, 13, 34, 499, DateTimeKind.Local).AddTicks(1090), new DateTime(2020, 9, 21, 14, 13, 34, 499, DateTimeKind.Local).AddTicks(1423) });
        }
    }
}
