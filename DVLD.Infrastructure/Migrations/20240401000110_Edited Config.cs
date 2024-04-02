using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditedConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAppointments_Users_UserId",
                table: "TestAppointments");

            migrationBuilder.DropIndex(
                name: "IX_TestAppointments_UserId",
                table: "TestAppointments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TestAppointments");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 18, 3, 1, 10, 164, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.CreateIndex(
                name: "IX_TestAppointments_CreatedByUserId",
                table: "TestAppointments",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestAppointments_Users_CreatedByUserId",
                table: "TestAppointments",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestAppointments_Users_CreatedByUserId",
                table: "TestAppointments");

            migrationBuilder.DropIndex(
                name: "IX_TestAppointments_CreatedByUserId",
                table: "TestAppointments");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TestAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateOfBirth",
                value: new DateTime(1999, 4, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateOfBirth",
                value: new DateTime(1999, 5, 31, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateOfBirth",
                value: new DateTime(1999, 6, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 101,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 102,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 103,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 104,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 105,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 106,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 107,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 108,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 109,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 110,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 111,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 112,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 113,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 114,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 115,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 116,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 117,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 118,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 119,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 120,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 121,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 122,
                column: "DateOfBirth",
                value: new DateTime(1999, 7, 31, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 123,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 124,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 125,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 126,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 127,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 128,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 129,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 130,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 131,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 132,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 133,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 134,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 135,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 136,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 137,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 138,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 139,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 140,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 141,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 142,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 143,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 144,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 145,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 146,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 147,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 148,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 149,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 150,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 151,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 152,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 153,
                column: "DateOfBirth",
                value: new DateTime(1999, 8, 31, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 154,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 155,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 156,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 157,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 158,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 159,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 160,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 161,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 162,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 163,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 164,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 165,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 166,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 167,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 168,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 169,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 170,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 171,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 18, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 172,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 19, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 173,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 20, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 174,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 21, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 175,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 22, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 176,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 23, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 177,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 24, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 178,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 25, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 179,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 26, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 180,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 27, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 181,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 28, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 182,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 29, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 183,
                column: "DateOfBirth",
                value: new DateTime(1999, 9, 30, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 184,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 1, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 185,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 2, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 186,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 3, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 187,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 4, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 188,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 5, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 189,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 6, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 190,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 7, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 191,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 8, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 192,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 9, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 193,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 10, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 194,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 11, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 195,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 12, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 196,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 13, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 197,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 14, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 198,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 15, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 199,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 16, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 200,
                column: "DateOfBirth",
                value: new DateTime(1999, 10, 17, 21, 38, 54, 345, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.CreateIndex(
                name: "IX_TestAppointments_UserId",
                table: "TestAppointments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestAppointments_Users_UserId",
                table: "TestAppointments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
