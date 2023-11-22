using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_rental.Migrations
{
    public partial class dbset5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_Signups_UsersId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_UsersId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "bookings");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_UserId",
                table: "bookings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_Signups_UserId",
                table: "bookings",
                column: "UserId",
                principalTable: "Signups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_Signups_UserId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_UserId",
                table: "bookings");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bookings_UsersId",
                table: "bookings",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_Signups_UsersId",
                table: "bookings",
                column: "UsersId",
                principalTable: "Signups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
