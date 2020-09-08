using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class _2020090802 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevMenuActions",
                columns: new[] { "Id", "ActionId", "CreateDate", "MenuId", "ModifyDate" },
                values: new object[,]
                {
                    { new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41dbae89-4b0c-4407-b18a-75d702639684"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1ce75274-4033-4081-88d0-6ba7ef00fddd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("235deae7-b378-488e-bab9-4523a84d620b"), new Guid("532e849c-b3d5-4d55-abfe-6e645ba2bae2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19b93b25-5230-425b-b5c5-625b708915b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"), new Guid("7b48a7f0-4077-4c1e-acd5-87ef0a8ace93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("daf50ad9-c46b-43de-aab2-ca4418785ba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7321), new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7421), new DateTime(2020, 9, 8, 9, 58, 57, 797, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 58, 57, 795, DateTimeKind.Local).AddTicks(9032), new DateTime(2020, 9, 8, 9, 58, 57, 795, DateTimeKind.Local).AddTicks(9571) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("235deae7-b378-488e-bab9-4523a84d620b"));

            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("41dbae89-4b0c-4407-b18a-75d702639684"));

            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("8df1d3ce-ed8a-4221-ae7d-12a886593cc5"));

            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("90f6e437-9fe3-4d5e-93b1-0d5e05d9d20d"));

            migrationBuilder.DeleteData(
                table: "DevMenuActions",
                keyColumn: "Id",
                keyValue: new Guid("ba6612d8-0f28-43c7-b4ec-5fb8e130b635"));

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("557b25cc-463d-4116-9d7d-5003d6acbf6a"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4000), new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "DevRoles",
                keyColumn: "Id",
                keyValue: new Guid("78d6d23b-64c1-4d23-b766-a19276be3d1c"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4084), new DateTime(2020, 9, 8, 9, 30, 42, 222, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "DevUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc9e5615-17d5-4ca2-adf9-200f903e0a7d"),
                columns: new[] { "CreateDate", "ModifyDate" },
                values: new object[] { new DateTime(2020, 9, 8, 9, 30, 42, 220, DateTimeKind.Local).AddTicks(8689), new DateTime(2020, 9, 8, 9, 30, 42, 220, DateTimeKind.Local).AddTicks(9199) });
        }
    }
}
