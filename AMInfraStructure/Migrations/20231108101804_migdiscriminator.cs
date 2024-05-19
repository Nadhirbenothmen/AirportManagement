using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMInfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class migdiscriminator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Passengers",
                newName: "IsTraveller");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTraveller",
                table: "Passengers",
                newName: "Discriminator");
        }
    }
}
