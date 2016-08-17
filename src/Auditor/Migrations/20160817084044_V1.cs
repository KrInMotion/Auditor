using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Auditor.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
