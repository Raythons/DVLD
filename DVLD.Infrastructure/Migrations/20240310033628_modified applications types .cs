using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifiedapplicationstypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 1,
                column: "ApplicationTypeTitle",
                value: "New Local Driving License Service ");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 2,
                column: "ApplicationTypeTitle",
                value: "Renew Driving License Service");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 3,
                columns: new[] { "ApplicationTypeFees", "ApplicationTypeTitle" },
                values: new object[] { 10f, "Replacment for a Lost Driving License" });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 4,
                column: "ApplicationTypeTitle",
                value: "Replacment for a Damaged  Driving License");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 5,
                column: "ApplicationTypeTitle",
                value: "Release Detained Driving License");

            migrationBuilder.InsertData(
                table: "ApplicationTypes",
                columns: new[] { "ApplicationTypeId", "ApplicationTypeFees", "ApplicationTypeTitle" },
                values: new object[,]
                {
                    { 6, 15.5f, "New International License " },
                    { 7, 15.5f, "Retake Test" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 3, 31, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 6, 36, 28, 93, DateTimeKind.Local).AddTicks(3919));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 1,
                column: "ApplicationTypeTitle",
                value: "Release");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 2,
                column: "ApplicationTypeTitle",
                value: "Renew");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 3,
                columns: new[] { "ApplicationTypeFees", "ApplicationTypeTitle" },
                values: new object[] { 15.5f, "Release Detained" });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 4,
                column: "ApplicationTypeTitle",
                value: "Lost");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ApplicationTypeId",
                keyValue: 5,
                column: "ApplicationTypeTitle",
                value: "Renew Damaged");

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
    }
}
