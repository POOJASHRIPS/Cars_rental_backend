using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_rental.Migrations
{
    public partial class dbset4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carsAvailability_Cars_CarsId",
                table: "carsAvailability");

            migrationBuilder.DropIndex(
                name: "IX_carsAvailability_CarsId",
                table: "carsAvailability");

            migrationBuilder.DropColumn(
                name: "CarsId",
                table: "carsAvailability");

            migrationBuilder.CreateIndex(
                name: "IX_carsAvailability_CarId",
                table: "carsAvailability",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_carsAvailability_Cars_CarId",
                table: "carsAvailability",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carsAvailability_Cars_CarId",
                table: "carsAvailability");

            migrationBuilder.DropIndex(
                name: "IX_carsAvailability_CarId",
                table: "carsAvailability");

            migrationBuilder.AddColumn<int>(
                name: "CarsId",
                table: "carsAvailability",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_carsAvailability_CarsId",
                table: "carsAvailability",
                column: "CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_carsAvailability_Cars_CarsId",
                table: "carsAvailability",
                column: "CarsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
