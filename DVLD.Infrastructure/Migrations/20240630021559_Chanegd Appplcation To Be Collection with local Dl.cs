using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChanegdAppplcationToBeCollectionwithlocalDl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Persons_PersonId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_PersonId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 31, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 11, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 17, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 18, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 19, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 20, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 21, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 22, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 23, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 24, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 25, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 26, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 27, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 28, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 29, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 30, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 12, 31, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 1, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 2, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 3, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 4, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 5, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 6, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 7, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 8, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 9, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 10, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 11, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 12, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 13, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 14, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 15, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(2000, 1, 16, 5, 15, 59, 175, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                column: "PersonId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                column: "PersonId",
                value: null);

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

            migrationBuilder.CreateIndex(
                name: "IX_Countries_PersonId",
                table: "Countries",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Persons_PersonId",
                table: "Countries",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
