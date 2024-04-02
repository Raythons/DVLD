using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedinitialclassesdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LicenseClasses",
                columns: new[] { "Id", "ClassDescription", "ClassFees", "ClassName", "DefaultValidityLength", "MinimumAllowedAge" },
                values: new object[,]
                {
                    { 1, "Allows driving small motorcycles.", 100m, "Small Motorcycle", 5, (byte)18 },
                    { 2, "Allows driving heavy motorcycles.", 150m, "Heavy Motorcycle", 5, (byte)21 },
                    { 3, "Allows ordinary driving of cars.", 200m, "Ordinary Driving License", 10, (byte)18 },
                    { 4, "Allows driving commercial vehicles.", 300m, "Commercial", 5, (byte)21 },
                    { 5, "Allows driving agricultural vehicles.", 120m, "Agricultural", 5, (byte)18 },
                    { 6, "Allows driving small and medium buses.", 250m, "Small and Medium Buses", 5, (byte)21 },
                    { 7, "Allows driving trucks and heavy vehicles.", 350m, "Truck and Heavy Vehicle", 5, (byte)21 }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 5, 13, 1, 430, DateTimeKind.Local).AddTicks(7985));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LicenseClasses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 1, 48, 1, 14, DateTimeKind.Local).AddTicks(2445));
        }
    }
}
