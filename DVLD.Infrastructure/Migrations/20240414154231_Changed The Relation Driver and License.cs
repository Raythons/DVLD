using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTheRelationDriverandLicense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Drivers_DriverId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_DriverId",
                table: "Licenses");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 18, 42, 30, 999, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 18, 42, 31, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 18, 42, 31, 0, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_DriverId",
                table: "Licenses",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Drivers_DriverId",
                table: "Licenses",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Drivers_DriverId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_DriverId",
                table: "Licenses");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 19, 29, 14, 867, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 19, 29, 14, 868, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_DriverId",
                table: "Licenses",
                column: "DriverId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Drivers_DriverId",
                table: "Licenses",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
