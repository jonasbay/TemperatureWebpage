using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$UMBcoNvbreRcLAas6lyLSu61CTAScfkeSuk.Bwr.CKdSANnLR5VbO");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$pwI2MCbtbaSlS5pcM7OrROlih9J9cCOZA0S0k3xhDWWP/zb42jr2O");
        }
    }
}
