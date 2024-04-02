using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVLD.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationTypes",
                columns: table => new
                {
                    ApplicationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationTypeFees = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypes", x => x.ApplicationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumAllowedAge = table.Column<byte>(type: "tinyint", nullable: false),
                    DefaultValidityLength = table.Column<int>(type: "int", nullable: false),
                    ClassFees = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestTypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestTypeFees = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalityCountryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Countries_NationalityCountryId",
                        column: x => x.NationalityCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationPersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationTypeId = table.Column<int>(type: "int", nullable: false),
                    ApplicationStatus = table.Column<short>(type: "smallint", nullable: false),
                    LastStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidFees = table.Column<decimal>(type: "smallmoney", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationTypes_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalTable: "ApplicationTypes",
                        principalColumn: "ApplicationTypeId");
                    table.ForeignKey(
                        name: "FK_Applications_People_ApplicationPersonId",
                        column: x => x.ApplicationPersonId,
                        principalTable: "People",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Applications_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Drivers_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LocalDrivingLicenseApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    LicenseClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalDrivingLicenseApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalDrivingLicenseApplications_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LocalDrivingLicenseApplications_LicenseClasses_LicenseClassId",
                        column: x => x.LicenseClassId,
                        principalTable: "LicenseClasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    LicenseClassId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaidFees = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IssueReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Licenses_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Licenses_LicenseClasses_LicenseClassId",
                        column: x => x.LicenseClassId,
                        principalTable: "LicenseClasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Licenses_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestTypeId = table.Column<int>(type: "int", nullable: false),
                    LocalDrivingLicenseApplicationId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidFees = table.Column<decimal>(type: "smallmoney", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestAppointments_LocalDrivingLicenseApplications_LocalDrivingLicenseApplicationId",
                        column: x => x.LocalDrivingLicenseApplicationId,
                        principalTable: "LocalDrivingLicenseApplications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TestAppointments_TestTypes_TestTypeId",
                        column: x => x.TestTypeId,
                        principalTable: "TestTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TestAppointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetainedLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseId = table.Column<int>(type: "int", nullable: false),
                    DetainDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FineFees = table.Column<decimal>(type: "smallmoney", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    IsReleased = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleasedByUserId = table.Column<int>(type: "int", nullable: false),
                    ReleaseApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetainedLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetainedLicenses_Applications_ReleaseApplicationId",
                        column: x => x.ReleaseApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetainedLicenses_Licenses_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetainedLicenses_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetainedLicenses_Users_ReleasedByUserId",
                        column: x => x.ReleasedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InternationalDrivingLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    IssueUsingLocalDrivingLicenseId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternationalDrivingLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternationalDrivingLicenses_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InternationalDrivingLicenses_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InternationalDrivingLicenses_Licenses_IssueUsingLocalDrivingLicenseId",
                        column: x => x.IssueUsingLocalDrivingLicenseId,
                        principalTable: "Licenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InternationalDrivingLicenses_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAppointmentId = table.Column<int>(type: "int", nullable: false),
                    TestResult = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: false),
                    TestTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_TestAppointments_TestAppointmentId",
                        column: x => x.TestAppointmentId,
                        principalTable: "TestAppointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tests_TestTypes_TestTypeId",
                        column: x => x.TestTypeId,
                        principalTable: "TestTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tests_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Austria" },
                    { 10, "Azerbaijan" },
                    { 11, "Bahrain" },
                    { 12, "Bangladesh" },
                    { 13, "Barbados" },
                    { 14, "Belarus" },
                    { 15, "Belgium" },
                    { 16, "Belize" },
                    { 17, "Benin" },
                    { 18, "Bhutan" },
                    { 19, "Bolivia" },
                    { 20, "Bosnia and Herzegovina" },
                    { 21, "Botswana" },
                    { 22, "Brazil" },
                    { 23, "Brunei" },
                    { 24, "Bulgaria" },
                    { 25, "Burkina Faso" },
                    { 26, "Burundi" },
                    { 27, "Cabo Verde" },
                    { 28, "Cambodia" },
                    { 29, "Cameroon" },
                    { 30, "Canada" },
                    { 31, "Central African Republic" },
                    { 32, "Chad" },
                    { 33, "Channel Islands" },
                    { 34, "Chile" },
                    { 35, "China" },
                    { 36, "Colombia" },
                    { 37, "Comoros" },
                    { 38, "Congo" },
                    { 39, "Costa Rica" },
                    { 40, "Côte d'Ivoire" },
                    { 41, "Croatia" },
                    { 42, "Cuba" },
                    { 43, "Cyprus" },
                    { 44, "Czech Republic" },
                    { 45, "Denmark" },
                    { 46, "Djibouti" },
                    { 47, "Dominica" },
                    { 48, "Dominican Republic" },
                    { 49, "DR Congo" },
                    { 50, "Ecuador" },
                    { 51, "Egypt" },
                    { 52, "El Salvador" },
                    { 53, "Equatorial Guinea" },
                    { 54, "Eritrea" },
                    { 55, "Estonia" },
                    { 56, "Eswatini" },
                    { 57, "Ethiopia" },
                    { 58, "Faeroe Islands" },
                    { 59, "Finland" },
                    { 60, "France" },
                    { 61, "French Guiana" },
                    { 62, "Gabon" },
                    { 63, "Gambia" },
                    { 64, "Georgia" },
                    { 65, "Germany" },
                    { 66, "Ghana" },
                    { 67, "Gibraltar" },
                    { 68, "Greece" },
                    { 69, "Grenada" },
                    { 70, "Guatemala" },
                    { 71, "Guinea" },
                    { 72, "Guinea-Bissau" },
                    { 73, "Guyana" },
                    { 74, "Haiti" },
                    { 75, "Holy See" },
                    { 76, "Honduras" },
                    { 77, "Hong Kong" },
                    { 78, "Hungary" },
                    { 79, "Iceland" },
                    { 80, "India" },
                    { 81, "Indonesia" },
                    { 82, "Iran" },
                    { 83, "Iraq" },
                    { 84, "Ireland" },
                    { 85, "Isle of Man" },
                    { 86, "Israel" },
                    { 87, "Italy" },
                    { 88, "Jamaica" },
                    { 89, "Japan" },
                    { 90, "Jordan" },
                    { 91, "Kazakhstan" },
                    { 92, "Kenya" },
                    { 93, "Kuwait" },
                    { 94, "Kyrgyzstan" },
                    { 95, "Laos" },
                    { 96, "Latvia" },
                    { 97, "Lebanon" },
                    { 98, "Lesotho" },
                    { 99, "Liberia" },
                    { 100, "Libya" },
                    { 101, "Liechtenstein" },
                    { 102, "Lithuania" },
                    { 103, "Luxembourg" },
                    { 104, "Macao" },
                    { 105, "Madagascar" },
                    { 106, "Malawi" },
                    { 107, "Malaysia" },
                    { 108, "Maldives" },
                    { 109, "Mali" },
                    { 110, "Malta" },
                    { 111, "Mauritania" },
                    { 112, "Mauritius" },
                    { 113, "Mayotte" },
                    { 114, "Mexico" },
                    { 115, "Moldova" },
                    { 116, "Monaco" },
                    { 117, "Mongolia" },
                    { 118, "Montenegro" },
                    { 119, "Morocco" },
                    { 120, "Mozambique" },
                    { 121, "Myanmar" },
                    { 122, "Namibia" },
                    { 123, "Nepal" },
                    { 124, "Netherlands" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" },
                    { 127, "Nigeria" },
                    { 128, "North Korea" },
                    { 129, "North Macedonia" },
                    { 130, "Norway" },
                    { 131, "Oman" },
                    { 132, "Pakistan" },
                    { 133, "Panama" },
                    { 134, "Paraguay" },
                    { 135, "Peru" },
                    { 136, "Philippines" },
                    { 137, "Poland" },
                    { 138, "Portugal" },
                    { 139, "Qatar" },
                    { 140, "Réunion" },
                    { 141, "Romania" },
                    { 142, "Russia" },
                    { 143, "Rwanda" },
                    { 144, "Saint Helena" },
                    { 145, "Saint Kitts and Nevis" },
                    { 146, "Saint Lucia" },
                    { 147, "Saint Vincent and the Grenadines" },
                    { 148, "San Marino" },
                    { 149, "Sao Tome & Principe" },
                    { 150, "Saudi Arabia" },
                    { 151, "Senegal" },
                    { 152, "Serbia" },
                    { 153, "Seychelles" },
                    { 154, "Sierra Leone" },
                    { 155, "Singapore" },
                    { 156, "Slovakia" },
                    { 157, "Slovenia" },
                    { 158, "Somalia" },
                    { 159, "South Africa" },
                    { 160, "South Korea" },
                    { 161, "South Sudan" },
                    { 162, "Spain" },
                    { 163, "Sri Lanka" },
                    { 164, "State of Palestine" },
                    { 165, "Sudan" },
                    { 166, "Suriname" },
                    { 167, "Sweden" },
                    { 168, "Switzerland" },
                    { 169, "Syria" },
                    { 170, "Taiwan" },
                    { 171, "Tajikistan" },
                    { 172, "Tanzania" },
                    { 173, "Thailand" },
                    { 174, "The Bahamas" },
                    { 175, "Timor-Leste" },
                    { 176, "Togo" },
                    { 177, "Trinidad and Tobago" },
                    { 178, "Tunisia" },
                    { 179, "Turkey" },
                    { 180, "Turkmenistan" },
                    { 181, "Uganda" },
                    { 182, "Ukraine" },
                    { 183, "United Arab Emirates" },
                    { 184, "United Kingdom" },
                    { 185, "United States" },
                    { 186, "Uruguay" },
                    { 187, "Uzbekistan" },
                    { 188, "Venezuela" },
                    { 189, "Vietnam" },
                    { 190, "Western Sahara" },
                    { 191, "Yemen" },
                    { 192, "Zambia" },
                    { 193, "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationPersonId",
                table: "Applications",
                column: "ApplicationPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationTypeId",
                table: "Applications",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CreatedByUserId",
                table: "Applications",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_CreatedByUserId",
                table: "DetainedLicenses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_LicenseId",
                table: "DetainedLicenses",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_ReleaseApplicationId",
                table: "DetainedLicenses",
                column: "ReleaseApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetainedLicenses_ReleasedByUserId",
                table: "DetainedLicenses",
                column: "ReleasedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CreatedByUserId",
                table: "Drivers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PersonId",
                table: "Drivers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternationalDrivingLicenses_ApplicationId",
                table: "InternationalDrivingLicenses",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternationalDrivingLicenses_CreatedByUserId",
                table: "InternationalDrivingLicenses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InternationalDrivingLicenses_DriverId",
                table: "InternationalDrivingLicenses",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternationalDrivingLicenses_IssueUsingLocalDrivingLicenseId",
                table: "InternationalDrivingLicenses",
                column: "IssueUsingLocalDrivingLicenseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_ApplicationId",
                table: "Licenses",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_CreatedByUserId",
                table: "Licenses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_DriverId",
                table: "Licenses",
                column: "DriverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_LicenseClassId",
                table: "Licenses",
                column: "LicenseClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalDrivingLicenseApplications_ApplicationId",
                table: "LocalDrivingLicenseApplications",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocalDrivingLicenseApplications_LicenseClassId",
                table: "LocalDrivingLicenseApplications",
                column: "LicenseClassId");

            migrationBuilder.CreateIndex(
                name: "IX_People_NationalityCountryId",
                table: "People",
                column: "NationalityCountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestAppointments_LocalDrivingLicenseApplicationId",
                table: "TestAppointments",
                column: "LocalDrivingLicenseApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestAppointments_TestTypeId",
                table: "TestAppointments",
                column: "TestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TestAppointments_UserId",
                table: "TestAppointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_CreatedByUserId",
                table: "Tests",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestAppointmentId",
                table: "Tests",
                column: "TestAppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestTypeId",
                table: "Tests",
                column: "TestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetainedLicenses");

            migrationBuilder.DropTable(
                name: "InternationalDrivingLicenses");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "TestAppointments");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "LocalDrivingLicenseApplications");

            migrationBuilder.DropTable(
                name: "TestTypes");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "LicenseClasses");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
