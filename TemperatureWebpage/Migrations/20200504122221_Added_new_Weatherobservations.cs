using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class Added_new_Weatherobservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "AirHumidity", "TimeOfDay" },
                values: new object[] { 20.0, new DateTime(2020, 5, 4, 14, 22, 21, 151, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                columns: new[] { "AirHumidity", "AirPressure", "Temperature", "TimeOfDay" },
                values: new object[] { 40.0, 40.0, 40.0, new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "WeatherObservationId", "AirHumidity", "AirPressure", "LocationRefId", "Temperature", "TimeOfDay" },
                values: new object[,]
                {
                    { 3, 30.0, 30.0, 1, 23.0, new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1144) },
                    { 4, 1000.0, 12.0, 1, 55.0, new DateTime(2020, 5, 4, 14, 22, 21, 155, DateTimeKind.Local).AddTicks(1150) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "AirHumidity", "TimeOfDay" },
                values: new object[] { 40.0, new DateTime(2020, 5, 4, 14, 11, 2, 213, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                columns: new[] { "AirHumidity", "AirPressure", "Temperature", "TimeOfDay" },
                values: new object[] { 1000.0, 0.0, 55.0, new DateTime(2020, 5, 4, 14, 11, 2, 216, DateTimeKind.Local).AddTicks(2728) });
        }
    }
}
