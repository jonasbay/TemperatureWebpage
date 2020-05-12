using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class editDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTOUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 254, nullable: true),
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTOUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    GPSLatitude = table.Column<double>(nullable: false),
                    GPSLongitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
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
                    LocationName = table.Column<string>(nullable: true),
                    LocationRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherObservations", x => x.WeatherObservationId);
                    table.ForeignKey(
                        name: "FK_WeatherObservations_Locations_LocationRefId",
                        column: x => x.LocationRefId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DTOUsers",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[] { 1, "default@gamil.com", "Default", "$2a$11$m9TE4XcAEdDaC/Hu0IRmRu9Ayqikl2YcRFf53Y2SLJTYUZgMzzYYy" });

            migrationBuilder.InsertData(
                table: "DTOUsers",
                columns: new[] { "Id", "Email", "Name", "PasswordHash" },
                values: new object[] { 2, "alex@gamil.com", "Alex", "$2a$11$MPFwsSaIdZeENTE7BGfu6eIubvJ6.9tS7e7TN3P5NfXi.X1oLgGsm" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "GPSLatitude", "GPSLongitude", "LocationName" },
                values: new object[] { 1, 2020.0, 10505.0, "USA" });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "WeatherObservationId", "AirHumidity", "AirPressure", "LocationName", "LocationRefId", "Temperature", "TimeOfDay" },
                values: new object[,]
                {
                    { 1, 20.0, 30.0, null, 1, 20.0, new DateTime(2020, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 40.0, 40.0, null, 1, 40.0, new DateTime(2019, 4, 6, 15, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 30.0, 30.0, null, 1, 23.0, new DateTime(2020, 4, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1000.0, 12.0, null, 1, 55.0, new DateTime(2020, 5, 10, 20, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationRefId",
                table: "WeatherObservations",
                column: "LocationRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTOUsers");

            migrationBuilder.DropTable(
                name: "WeatherObservations");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
