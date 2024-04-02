using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenamedApplicationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationStatus",
                table: "Applications",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 3, 35, 10, 77, DateTimeKind.Local).AddTicks(1613));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Applications",
                newName: "ApplicationStatus");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 23, 12, 21, 276, DateTimeKind.Local).AddTicks(5174));
        }
    }
}
