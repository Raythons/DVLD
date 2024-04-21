using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReDdesignedtehrelationsAGENO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypes_TestTypeId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_TestTypeId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TestTypeId",
                table: "Tests");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestTypeId",
                table: "Tests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 19, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 20, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 21, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 22, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 23, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 24, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 25, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 26, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 27, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 28, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 29, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 30, 19, 20, 12, 152, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestTypeId",
                table: "Tests",
                column: "TestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypes_TestTypeId",
                table: "Tests",
                column: "TestTypeId",
                principalTable: "TestTypes",
                principalColumn: "Id");
        }
    }
}
