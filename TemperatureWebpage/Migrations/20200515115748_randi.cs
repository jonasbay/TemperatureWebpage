using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class randi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$smyU1UZDV6KOAh/XPGyVyexwl4i5My1vW0Ts2mkgML7YXuId7RTiy");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$oJZ06qB.a6CcM/ajjfv7T.qarL7ce5PUXkkKE44ez72cSnh8JzW6q");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "LocationName",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "LocationName",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "LocationName",
                value: "USA");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "LocationName",
                value: "USA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$rpk1pjk6xLxn1ZSUqvAfc.k50/0zhJjXFwRyxHM0o8abof1sj/Wfu");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$7c2j689CL9jde/Xx5rURZetjJih6PWS56K7KbmbMN/vOLqEWf6mQW");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                column: "LocationName",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2,
                column: "LocationName",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 3,
                column: "LocationName",
                value: null);

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 4,
                column: "LocationName",
                value: null);
        }
    }
}
