using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GameX.Migrations
{
    public partial class EvetAdrss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Places_PlaceId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Events_PlaceId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventAdressId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventAdress",
                columns: table => new
                {
                    EventAdressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    HouseNumber = table.Column<string>(nullable: false),
                    Lat = table.Column<double>(nullable: false),
                    Lng = table.Column<double>(nullable: false),
                    PostCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAdress", x => x.EventAdressId);
                });

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventAdress_EventAdressId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventAdress");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventAdressId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventAdressId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adress = table.Column<string>(nullable: false),
                    Lat = table.Column<double>(nullable: false),
                    Lng = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlaceId",
                table: "Events",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Places_PlaceId",
                table: "Events",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
