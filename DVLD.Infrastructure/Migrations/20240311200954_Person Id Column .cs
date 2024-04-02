using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PersonIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 23, 9, 53, 840, DateTimeKind.Local).AddTicks(9911));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Applications");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 19, 41, 51, 513, DateTimeKind.Local).AddTicks(8398));
        }
    }
}
