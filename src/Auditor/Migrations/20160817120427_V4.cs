using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Auditor.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WifiChecks_Regions_RegionId",
                table: "WifiChecks");

            migrationBuilder.DropIndex(
                name: "IX_WifiChecks_RegionId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "WifiChecks");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capital = table.Column<string>(maxLength: 255, nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    Region = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "TerritoryId",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WifiChecks",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.CreateIndex(
                name: "IX_WifiChecks_TerritoryId",
                table: "WifiChecks",
                column: "TerritoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_WifiChecks_Territories_TerritoryId",
                table: "WifiChecks",
                column: "TerritoryId",
                principalTable: "Territories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WifiChecks_Territories_TerritoryId",
                table: "WifiChecks");

            migrationBuilder.DropIndex(
                name: "IX_WifiChecks_TerritoryId",
                table: "WifiChecks");

            migrationBuilder.DropColumn(
                name: "TerritoryId",
                table: "WifiChecks");

            migrationBuilder.DropTable(
                name: "Territories");

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

            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "WifiChecks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WifiChecks",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_WifiChecks_RegionId",
                table: "WifiChecks",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WifiChecks_Regions_RegionId",
                table: "WifiChecks",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
