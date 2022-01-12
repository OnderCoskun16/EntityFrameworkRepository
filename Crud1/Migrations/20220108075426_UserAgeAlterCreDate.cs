using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud1.Migrations
{
    public partial class UserAgeAlterCreDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreDate",
                table: "Kullanici",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreDate",
                table: "Kullanici");
        }
    }
}
