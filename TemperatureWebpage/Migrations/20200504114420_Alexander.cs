using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class Alexander : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 13, 44, 20, 214, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 13, 44, 20, 217, DateTimeKind.Local).AddTicks(2776));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 27, 15, 50, 48, 365, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 27, 15, 50, 48, 368, DateTimeKind.Local).AddTicks(7118));
        }
    }
}
