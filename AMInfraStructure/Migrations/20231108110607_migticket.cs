using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMInfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class migticket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyReservations");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    PassengerFK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Siege = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    MyPassengerPassportNumber = table.Column<string>(type: "nvarchar(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.FlightFK, x.PassengerFK });
                    table.ForeignKey(
                        name: "FK_Ticket_Flights_FlightFK",
                        column: x => x.FlightFK,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_MyPassengerPassportNumber",
                        column: x => x.MyPassengerPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MyPassengerPassportNumber",
                table: "Ticket",
                column: "MyPassengerPassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "MyReservations",
                columns: table => new
                {
                    ListFlightFlightId = table.Column<int>(type: "int", nullable: false),
                    ListPassengerPassportNumber = table.Column<string>(type: "nvarchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReservations", x => new { x.ListFlightFlightId, x.ListPassengerPassportNumber });
                    table.ForeignKey(
                        name: "FK_MyReservations_Flights_ListFlightFlightId",
                        column: x => x.ListFlightFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyReservations_Passengers_ListPassengerPassportNumber",
                        column: x => x.ListPassengerPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyReservations_ListPassengerPassportNumber",
                table: "MyReservations",
                column: "ListPassengerPassportNumber");
        }
    }
}
