using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class MovedAuth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$0arsaGCBGEtK6qEsyoi9c.cCocIzA4RaYXHL0XHqW.mE1VET3zj.a");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$YWRUvVrFdBb86QxqyugDD..VaE4j/JTX/VLW928VMtbRLWpCXic5.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
