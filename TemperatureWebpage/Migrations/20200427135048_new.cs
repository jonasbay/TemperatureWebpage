using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.DropIndex(
                name: "IX_WeatherObservations_LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationName",
                keyValue: "USA");

            migrationBuilder.DropColumn(
                name: "LocationRefName",
                table: "WeatherObservations");

            migrationBuilder.AddColumn<int>(
                name: "LocationRefId",
                table: "WeatherObservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Locations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Locations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "GPSLatitude", "GPSLongitude", "LocationName" },
                values: new object[] { 1, 2020.0, 10505.0, "USA" });

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "LocationRefId", "TimeOfDay" },
                values: new object[] { 1, new DateTime(2020, 4, 27, 15, 50, 48, 365, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "WeatherObservationId", "AirHumidity", "AirPressure", "LocationRefId", "Temperature", "TimeOfDay" },
                values: new object[] { 2, 1000.0, 0.0, 1, 55.0, new DateTime(2020, 4, 27, 15, 50, 48, 368, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationRefId",
                table: "WeatherObservations",
                column: "LocationRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefId",
                table: "WeatherObservations",
                column: "LocationRefId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefId",
                table: "WeatherObservations");

            migrationBuilder.DropIndex(
                name: "IX_WeatherObservations_LocationRefId",
                table: "WeatherObservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "LocationRefId",
                table: "WeatherObservations");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Locations");

            migrationBuilder.AddColumn<string>(
                name: "LocationRefName",
                table: "WeatherObservations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "Locations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationName");

            migrationBuilder.UpdateData(
                table: "WeatherObservations",
                keyColumn: "WeatherObservationId",
                keyValue: 1,
                columns: new[] { "LocationRefName", "TimeOfDay" },
                values: new object[] { "USA", new DateTime(2020, 4, 27, 15, 35, 30, 425, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherObservations_LocationRefName",
                table: "WeatherObservations",
                column: "LocationRefName");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherObservations_Locations_LocationRefName",
                table: "WeatherObservations",
                column: "LocationRefName",
                principalTable: "Locations",
                principalColumn: "LocationName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
