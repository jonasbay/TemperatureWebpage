using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class updatedata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2019, 4, 6, 15, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 10, 20, 30, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 11, 14, 4, 0, 535, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 11, 14, 4, 0, 538, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 11, 14, 4, 0, 538, DateTimeKind.Local).AddTicks(7769));
        }
    }
}
