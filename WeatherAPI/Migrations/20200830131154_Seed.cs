using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "City", "Conditions", "MaxTemperature", "MinTemperature", "Outlook", "WindDirection", "WindSpeed" },
                values: new object[,]
                {
                    { 1, "Dublin", "Sunny", 24.0, 16.0, "Cloudy", "North", 120 },
                    { 2, "London", "Cloudy", 20.0, 12.0, "Sunny", "North", 140 },
                    { 3, "Spain", "Sunny", 29.0, 20.0, "Sunny", "South", 60 },
                    { 4, "Berlin", "Overcast", 20.0, 12.0, "Cloudy", "South", 112 },
                    { 5, "Amsterdam", "Rain", 21.0, 14.0, "Drizzle", "East", 120 },
                    { 6, "Tokyo", "Drizzle", 19.0, 11.0, "Rain", "East", 120 },
                    { 7, "Vancouver", "Snow", -10.0, -14.0, "Fog", "West", 12 },
                    { 8, "Toronto", "Fog", 10.0, 0.0, "Overcast", "West", 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weather",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
