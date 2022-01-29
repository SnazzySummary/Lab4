using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4.Data.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                column: "ProvinceCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                column: "ProvinceCode",
                value: "AB");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                column: "ProvinceCode",
                value: "ON");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                column: "ProvinceCode",
                value: "ON");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                column: "ProvinceCode",
                value: "ON");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Cities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "BC", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "BC", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "BC", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "AB", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "AB", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "AB", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "ON", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "ON", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "ON", null });
        }
    }
}
