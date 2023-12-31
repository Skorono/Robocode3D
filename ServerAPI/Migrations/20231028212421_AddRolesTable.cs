﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<char>(
                name: "PlayerRoleId",
                table: "Players",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ');

            migrationBuilder.AddColumn<char>(
                name: "RoleId",
                table: "Players",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ');

            migrationBuilder.CreateTable(
                name: "PlayerRoles",
                columns: table => new
                {
                    Id = table.Column<char>(type: "character(1)", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlayerRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 'A', "Admin" },
                    { 'H', "Helper" },
                    { 'P', "Player" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerRoleId",
                table: "Players",
                column: "PlayerRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_PlayerRoles_PlayerRoleId",
                table: "Players",
                column: "PlayerRoleId",
                principalTable: "PlayerRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_PlayerRoles_PlayerRoleId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "PlayerRoles");

            migrationBuilder.DropIndex(
                name: "IX_Players_PlayerRoleId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerRoleId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Players");

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Login", "Name", "Password" },
                values: new object[] { 1, "qwerty123", "Listik", "123" });
        }
    }
}
