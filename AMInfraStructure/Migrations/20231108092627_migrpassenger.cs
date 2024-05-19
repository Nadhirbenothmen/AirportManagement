using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMInfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class migrpassenger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Passengers",
                newName: "PassLastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Passengers",
                newName: "PassFirstName");

            migrationBuilder.AlterColumn<string>(
                name: "PassLastName",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PassFirstName",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassLastName",
                table: "Passengers",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "PassFirstName",
                table: "Passengers",
                newName: "FullName_FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName_LastName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FullName_FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
