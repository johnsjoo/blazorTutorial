using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherDataManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temp = table.Column<float>(type: "real", nullable: false),
                    Humidity = table.Column<float>(type: "real", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherData",
                columns: new[] { "Id", "DateAndTime", "Humidity", "Location", "Temp" },
                values: new object[] { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48f, "Inne", 24.5f });

            migrationBuilder.InsertData(
                table: "WeatherData",
                columns: new[] { "Id", "DateAndTime", "Humidity", "Location", "Temp" },
                values: new object[] { 2, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12f, "Inne", 25.5f });

            migrationBuilder.InsertData(
                table: "WeatherData",
                columns: new[] { "Id", "DateAndTime", "Humidity", "Location", "Temp" },
                values: new object[] { 3, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34f, "Inne", 14.5f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherData");
        }
    }
}
