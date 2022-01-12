﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud1.Migrations
{
    public partial class UserEmailColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kullanici",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kullanici");
        }
    }
}
