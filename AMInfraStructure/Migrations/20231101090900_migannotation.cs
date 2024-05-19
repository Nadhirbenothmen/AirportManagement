﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMInfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class migannotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_ListPassengerId",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "ListPassengerId",
                table: "FlightPassenger");

            migrationBuilder.RenameColumn(
                name: "MyPlanePlaneId",
                table: "Flights",
                newName: "Planefk");

            migrationBuilder.RenameColumn(
                name: "AirlineLogo",
                table: "Flights",
                newName: "Airline");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_MyPlanePlaneId",
                table: "Flights",
                newName: "IX_Flights_Planefk");

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "Passengers",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ListPassengerPassportNumber",
                table: "FlightPassenger",
                type: "nvarchar(7)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "ListFlightFlightId", "ListPassengerPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_ListPassengerPassportNumber",
                table: "FlightPassenger",
                column: "ListPassengerPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengerPassportNumber",
                table: "FlightPassenger",
                column: "ListPassengerPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_Planefk",
                table: "Flights",
                column: "Planefk",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengerPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_Planefk",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropIndex(
                name: "IX_FlightPassenger_ListPassengerPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "ListPassengerPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.RenameColumn(
                name: "Planefk",
                table: "Flights",
                newName: "MyPlanePlaneId");

            migrationBuilder.RenameColumn(
                name: "Airline",
                table: "Flights",
                newName: "AirlineLogo");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_Planefk",
                table: "Flights",
                newName: "IX_Flights_MyPlanePlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "PassportNumber",
                table: "Passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ListPassengerId",
                table: "FlightPassenger",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "ListFlightFlightId", "ListPassengerId" });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_ListPassengerId",
                table: "FlightPassenger",
                column: "ListPassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_ListPassengerId",
                table: "FlightPassenger",
                column: "ListPassengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights",
                column: "MyPlanePlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
