using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Auditor.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "WifiChecks",
                maxLength: 255,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "WifiChecks",
                maxLength: 255,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "WifiChecks",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "WifiChecks",
                nullable: true);
        }
    }
}
