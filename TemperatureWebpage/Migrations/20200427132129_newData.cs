using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "WeatherObservations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationName", "GPSLatitude", "GPSLongitude" },
                values: new object[] { "USA", 2020.0, 10505.0 });

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "LocationName", "TimeOfDay" },
                values: new object[] { "USA", new DateTime(2020, 4, 27, 15, 21, 29, 2, DateTimeKind.Local).AddTicks(1712) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationName",
                keyValue: "USA");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "WeatherObservations");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 27, 15, 5, 22, 502, DateTimeKind.Local).AddTicks(505));
        }
    }
}
