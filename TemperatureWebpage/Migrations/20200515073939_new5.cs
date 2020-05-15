using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$gggdVzPe2F88AdGqDF6FnOt/YfLa04s2ecRxdTb6KXL4mCIfwVgE2");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$4NKSncPgen08.U03AunbPuPm83Na6bMnYNUm8jse7ySDNazC1WF2a");
        }
    }
}
