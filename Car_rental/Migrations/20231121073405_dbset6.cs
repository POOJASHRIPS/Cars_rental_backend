using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_rental.Migrations
{
    public partial class dbset6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "carsAvailability");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "carsAvailability",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "carsAvailability");

            migrationBuilder.AddColumn<string>(
                name: "Available",
                table: "carsAvailability",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
