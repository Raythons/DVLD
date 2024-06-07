using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedTheDefaultValueOfReleaseDateTimeInDetainedLicense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "DetainedLicenses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 26, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 27, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 28, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 29, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 30, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 1, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 2, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 3, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 4, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 5, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 6, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 7, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 8, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 9, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 10, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 11, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 12, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 13, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 14, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 15, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 16, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 17, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 18, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 19, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 20, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 21, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 22, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 23, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 24, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 25, 0, 9, 21, 291, DateTimeKind.Local).AddTicks(7374));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "DetainedLicenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 0, 1, 23, 625, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 0, 1, 23, 626, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 1, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 2, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 3, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 4, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 5, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 6, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 7, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 8, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 9, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 10, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 11, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 12, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 13, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 14, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 15, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 16, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 17, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 18, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 19, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 20, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 21, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 22, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 23, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 24, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 25, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 26, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 27, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 28, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 29, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 30, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 1, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 2, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 3, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 4, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 5, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 6, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 7, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 8, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 9, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 10, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 11, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 12, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 13, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 14, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 15, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 16, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 17, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 18, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 19, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 20, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 21, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 22, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 23, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 24, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 25, 0, 1, 23, 626, DateTimeKind.Local).AddTicks(735));
        }
    }
}
