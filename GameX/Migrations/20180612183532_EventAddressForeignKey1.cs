using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameX.Migrations
{
    public partial class EventAddressForeignKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAdress_Events_EventId",
                table: "EventAdress");

            migrationBuilder.DropIndex(
                name: "IX_EventAdress_EventId",
                table: "EventAdress");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "EventAdress");

            migrationBuilder.AddColumn<int>(
                name: "EventAdressId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "EventAdressId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "EventAdress",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EventAdress_EventId",
                table: "EventAdress",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventAdress_Events_EventId",
                table: "EventAdress",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
