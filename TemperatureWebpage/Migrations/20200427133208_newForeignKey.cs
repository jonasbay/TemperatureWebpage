using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class newForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherObservations_Locations_LocationsLocationName",
                table: "WeatherObservations");

            migrationBuilder.DropIndex(
                name: "IX_WeatherObservations_LocationsLocationName",
                table: "WeatherObservations");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "WeatherObservations");

            migrationBuilder.DropColumn(
                name: "LocationsLocationName",
                table: "WeatherObservations");

            migrationBuilder.AddColumn<string>(
                name: "LocationRefName",
                table: "WeatherObservations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "LocationRefName", "TimeOfDay" },
                values: new object[] { "USA", new DateTime(2020, 4, 27, 15, 32, 8, 618, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationRefName",
                table: "WeatherObservations",
                column: "LocationRefName");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefName",
                table: "WeatherObservations",
                column: "LocationRefName",
                principalTable: "Locations",
                principalColumn: "LocationName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.DropIndex(
                name: "IX_WeatherObservations_LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.DropColumn(
                name: "LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "WeatherObservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationsLocationName",
                table: "WeatherObservations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "LocationName", "TimeOfDay" },
                values: new object[] { "USA", new DateTime(2020, 4, 27, 15, 21, 29, 2, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationsLocationName",
                table: "WeatherObservations",
                column: "LocationsLocationName");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherObservations_Locations_LocationsLocationName",
                table: "WeatherObservations",
                column: "LocationsLocationName",
                principalTable: "Locations",
                principalColumn: "LocationName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
