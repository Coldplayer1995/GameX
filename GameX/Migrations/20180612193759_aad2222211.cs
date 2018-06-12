using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameX.Migrations
{
    public partial class aad2222211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Events_EventAdressId",
                table: "Events",
                column: "EventAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventAdress_EventAdressId",
                table: "Events",
                column: "EventAdressId",
                principalTable: "EventAdress",
                principalColumn: "EventAdressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventAdress_EventAdressId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventAdressId",
                table: "Events");
        }
    }
}
