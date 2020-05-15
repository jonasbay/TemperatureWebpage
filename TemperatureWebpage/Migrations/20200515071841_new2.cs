using Microsoft.EntityFrameworkCore.Migrations;

namespace TemperatureWebpage.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$jrDTe1nJqcYv0YnUTL5L9Ot0uu5USvlHczc/rATYJkAplCFqyw5Yq");

            migrationBuilder.UpdateData(
                table: "DTOUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$4rD7d95PnfCnlNbPuDbO1Ocz4VMkNV13ULff2LHi.xH5VQ8VQtfKW");
        }
    }
}
