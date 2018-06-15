using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameX.Migrations
{
    public partial class EventsModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Events_DisciplineId",
                table: "Events",
                column: "DisciplineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Disciplines_DisciplineId",
                table: "Events",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DieciplineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Disciplines_DisciplineId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_DisciplineId",
                table: "Events");
        }
    }
}
