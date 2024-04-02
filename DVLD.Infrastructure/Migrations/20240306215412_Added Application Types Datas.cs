using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedApplicationTypesDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationTypes",
                columns: new[] { "ApplicationTypeId", "ApplicationTypeFees", "ApplicationTypeTitle" },
                values: new object[,]
                {
                    { 1, 15.5f, "Release" },
                    { 2, 5f, "Renew" },
                    { 3, 15.5f, "Release Detained" },
                    { 4, 15.5f, "Lost" },
                    { 5, 15.5f, "Renew Damaged" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 0, 54, 11, 935, DateTimeKind.Local).AddTicks(5272));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 13, 26, 33, 154, DateTimeKind.Local).AddTicks(8941));
        }
    }
}
