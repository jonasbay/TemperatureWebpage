using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$lhlKhaVCl.Y38wMVhNg6JOpx5HfJebQalxDjiPl1STGDp55AlpxQW");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$V2.CusF5aZAHG5IyL4Fyn.XY03xj8BaZoxjoXj0jbshRKwjFkDI0S");
        }
    }
}
