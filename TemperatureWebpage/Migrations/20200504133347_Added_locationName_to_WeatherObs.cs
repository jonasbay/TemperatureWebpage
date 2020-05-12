using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class Added_locationName_to_WeatherObs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "WeatherObservations",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "WeatherObservations");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 22, 21, 151, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "TimeOfDay",
                value: new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1150));
        }
    }
}
