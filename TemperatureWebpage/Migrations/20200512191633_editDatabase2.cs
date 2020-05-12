using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class editDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$UjOf6yKman8IL7LTAX86y.bq2nOsLZJhAAnR9KxI2yHnD7EDBC21.");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$TjZEdL0AJNUCPf7kp3vju.09QpMxN9dQMzdHCzT9nHoLS3AqGeFba");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$m9TE4XcAEdDaC/Hu0IRmRu9Ayqikl2YcRFf53Y2SLJTYUZgMzzYYy");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$MPFwsSaIdZeENTE7BGfu6eIubvJ6.9tS7e7TN3P5NfXi.X1oLgGsm");
        }
    }
}
