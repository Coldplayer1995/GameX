using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameX.Migrations
{
    public partial class CoordsNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "EventAdress",
                newName: "Street");

            migrationBuilder.AlterColumn<string>(
                name: "Coords",
                table: "Events",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "EventAdress",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "Coords",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
