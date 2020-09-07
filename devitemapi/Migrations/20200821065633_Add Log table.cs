using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace devitemapi.Migrations
{
    public partial class AddLogtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Exception = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nlogrecs", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nlogrecs");

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4175), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4293), new DateTime(2020, 8, 12, 16, 47, 6, 84, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 8, 12, 16, 47, 6, 81, DateTimeKind.Local).AddTicks(7769), new DateTime(2020, 8, 12, 16, 47, 6, 82, DateTimeKind.Local).AddTicks(8069) });
        }
    }
}