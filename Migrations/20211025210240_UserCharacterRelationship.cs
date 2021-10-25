﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetRpg.Migrations
{
    public partial class UserCharacterRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Characters",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_userId",
                table: "Characters",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Users_userId",
                table: "Characters",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Users_userId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_userId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Characters");
        }
    }
}
