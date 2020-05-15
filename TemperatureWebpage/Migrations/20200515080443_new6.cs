using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$M/mmVjWpNRMOX8wTxtdc3OWut/VdBixUL8RqQdPgyw/KaIUZuiLmu");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$soSLQBoFqYtKb4KdXGkTH.IUTllhdqno/W6bV0CvdJzEeixY70d.C");
        }
    }
}
