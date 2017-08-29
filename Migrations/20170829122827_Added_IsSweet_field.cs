using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e190.Migrations
{
    public partial class Added_IsSweet_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSweet",
                table: "Pies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSweet",
                table: "Pies");
        }
    }
}
