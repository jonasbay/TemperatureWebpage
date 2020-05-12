using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 15, 33, 46, 704, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 15, 33, 46, 707, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 15, 33, 46, 707, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 15, 33, 46, 707, DateTimeKind.Local).AddTicks(8139));
        }
    }
}
