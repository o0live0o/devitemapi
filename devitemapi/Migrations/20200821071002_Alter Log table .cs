using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class AlterLogtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogContent",
                table: "Nlogrecs",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogContent",
                table: "Nlogrecs");

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 14, 56, 33, 417, DateTimeKind.Local).AddTicks(1099), new DateTime(2020, 8, 21, 14, 56, 33, 417, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 14, 56, 33, 417, DateTimeKind.Local).AddTicks(1331), new DateTime(2020, 8, 21, 14, 56, 33, 417, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 21, 14, 56, 33, 414, DateTimeKind.Local).AddTicks(8119), new DateTime(2020, 8, 21, 14, 56, 33, 414, DateTimeKind.Local).AddTicks(8648) });
        }
    }
}
