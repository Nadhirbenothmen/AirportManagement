﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMInfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class piltmi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pilot",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pilot",
                table: "Flights");
        }
    }
}
