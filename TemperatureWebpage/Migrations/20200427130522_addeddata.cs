using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class addeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "WeatherObservationId", "AirHumidity", "AirPressure", "LocationsLocationName", "Temperature", "TimeOfDay" },
                values: new object[] { 1, 40.0, 30.0, null, 20.0, new DateTime(2020, 4, 27, 15, 5, 22, 502, DateTimeKind.Local).AddTicks(505) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1);
        }
    }
}
