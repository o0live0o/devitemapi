using Microsoft.EntityFrameworkCore.Migrations;

namespace devitemapi.Migrations
{
    public partial class ModifyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnable",
                table: "DevUsers");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DevUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "DevUsers");

            migrationBuilder.AddColumn<int>(
                name: "IsEnable",
                table: "DevUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
