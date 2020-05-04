using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class Trying_new_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 11, 2, 213, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 11, 2, 216, DateTimeKind.Local).AddTicks(2728));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
