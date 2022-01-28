using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population", "Province" },
                values: new object[] { "Mission", 50000, "BC" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 3, "Maple Ridge", 80000, "BC", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 4, "Calgary", 10000000, "AB", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 5, "Drumheller", 40000, "AB", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 6, "Edmondton", 1000000, "AB", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 7, "Toronto", 1000000, "ON", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 8, "Mississauga", 2001511, "ON", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[] { 9, "Hamilton", 150000, "ON", null });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "ON", "Ontatrio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "ON");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population", "Province" },
                values: new object[] { "Calgary", 10000000, "AB" });
        }
    }
}
