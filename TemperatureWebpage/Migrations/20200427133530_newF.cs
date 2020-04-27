using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class newF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 27, 15, 35, 30, 425, DateTimeKind.Local).AddTicks(8752));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "TimeOfDay",
                value: new DateTime(2020, 4, 27, 15, 32, 8, 618, DateTimeKind.Local).AddTicks(6365));
        }
    }
}
