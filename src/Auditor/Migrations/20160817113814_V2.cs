using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Auditor.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WifiChecks_Users_ResponsibleId",
                table: "WifiChecks");

            migrationBuilder.DropIndex(
                name: "IX_WifiChecks_ResponsibleId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "ResponsibleId",
                table: "WifiChecks");

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckDate",
                table: "WifiChecks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "WifiChecks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "WifiChecks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provider",
                table: "WifiChecks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskTime",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViolationsCount",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WifiChecks_RegionId",
                table: "WifiChecks",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_WifiChecks_UserId",
                table: "WifiChecks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WifiChecks_Regions_RegionId",
                table: "WifiChecks",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WifiChecks_Users_UserId",
                table: "WifiChecks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WifiChecks_Regions_RegionId",
                table: "WifiChecks");

            migrationBuilder.DropForeignKey(
                name: "FK_WifiChecks_Users_UserId",
                table: "WifiChecks");

            migrationBuilder.DropIndex(
                name: "IX_WifiChecks_RegionId",
                table: "WifiChecks");

            migrationBuilder.DropIndex(
                name: "IX_WifiChecks_UserId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "CheckDate",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "Provider",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "TaskTime",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "ViolationsCount",
                table: "WifiChecks");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleId",
                table: "WifiChecks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WifiChecks_ResponsibleId",
                table: "WifiChecks",
                column: "ResponsibleId");

            migrationBuilder.AddForeignKey(
                name: "FK_WifiChecks_Users_ResponsibleId",
                table: "WifiChecks",
                column: "ResponsibleId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
