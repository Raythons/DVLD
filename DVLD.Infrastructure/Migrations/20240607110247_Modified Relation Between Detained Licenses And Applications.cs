using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedRelationBetweenDetainedLicensesAndApplications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DetainedLicenses_ReleaseApplicationId",
                table: "DetainedLicenses");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 25, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 26, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 27, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 28, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 29, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 30, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 1, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 2, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 3, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 4, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 5, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 6, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 7, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 8, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 9, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 10, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 11, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 12, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 13, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 14, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 15, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 16, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 17, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 18, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 19, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 20, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 21, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 22, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 23, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 24, 14, 2, 46, 960, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_ReleaseApplicationId",
                table: "DetainedLicenses",
                column: "ReleaseApplicationId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DetainedLicenses_ReleaseApplicationId",
                table: "DetainedLicenses");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 14, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 15, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 16, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 17, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 18, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 19, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 20, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 21, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 22, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 23, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 24, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 25, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 26, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 27, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 28, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 29, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 30, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 1, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 2, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 3, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 4, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 5, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 6, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 7, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 8, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 9, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 10, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 11, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 12, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 13, 18, 6, 10, 194, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_ReleaseApplicationId",
                table: "DetainedLicenses",
                column: "ReleaseApplicationId");
        }
    }
}
