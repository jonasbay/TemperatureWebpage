using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$Sylsecy8fWACV7t7y823rOqsLGBcZA.O6/4F21aZRTDlySwhbpZN2");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$5qRzit.irqWKKtFuIOlUVOtspUi/AUmL83n9zCx7Zdy9iBUp4dmQ6");
        }
    }
}
