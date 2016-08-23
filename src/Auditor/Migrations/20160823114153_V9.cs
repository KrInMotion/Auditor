using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Auditor.Migrations
{
    public partial class V9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResultName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskResults", x => x.Id);
                });

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "WifiChecks",
                maxLength: 256,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "WifiChecks",
                maxLength: 256,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Territories",
                maxLength: 256,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Capital",
                table: "Territories",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskResults");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                maxLength: 255,
                nullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Territories",
                maxLength: 255,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Capital",
                table: "Territories",
                maxLength: 255,
                nullable: true);
        }
    }
}
