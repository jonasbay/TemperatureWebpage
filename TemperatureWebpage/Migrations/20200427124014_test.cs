using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationName = table.Column<string>(nullable: false),
                    GPSLatitude = table.Column<double>(nullable: false),
                    GPSLongitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationName);
                });

            migrationBuilder.CreateTable(
                name: "WeatherObservations",
                columns: table => new
                {
                    WeatherObservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeOfDay = table.Column<DateTime>(nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    AirPressure = table.Column<double>(nullable: false),
                    AirHumidity = table.Column<double>(nullable: false),
                    LocationsLocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherObservations", x => x.WeatherObservationId);
                    table.ForeignKey(
                        name: "FK_WeatherObservations_Locations_LocationsLocationName",
                        column: x => x.LocationsLocationName,
                        principalTable: "Locations",
                        principalColumn: "LocationName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationsLocationName",
                table: "WeatherObservations",
                column: "LocationsLocationName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherObservations");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
