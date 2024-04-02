using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DVLD.Infrastructure.Migrations
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
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
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
                    Image = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Countries_NationalityCountryId",
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
                        name: "FK_Users_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
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
                        name: "FK_Drivers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Drivers_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName", "PersonId" },
                values: new object[,]
                {
                    { 1, "Afghanistan", null },
                    { 2, "Albania", null },
                    { 3, "Algeria", null },
                    { 4, "Andorra", null },
                    { 5, "Angola", null },
                    { 6, "Antigua and Barbuda", null },
                    { 7, "Argentina", null },
                    { 8, "Armenia", null },
                    { 9, "Austria", null },
                    { 10, "Azerbaijan", null },
                    { 11, "Bahrain", null },
                    { 12, "Bangladesh", null },
                    { 13, "Barbados", null },
                    { 14, "Belarus", null },
                    { 15, "Belgium", null },
                    { 16, "Belize", null },
                    { 17, "Benin", null },
                    { 18, "Bhutan", null },
                    { 19, "Bolivia", null },
                    { 20, "Bosnia and Herzegovina", null },
                    { 21, "Botswana", null },
                    { 22, "Brazil", null },
                    { 23, "Brunei", null },
                    { 24, "Bulgaria", null },
                    { 25, "Burkina Faso", null },
                    { 26, "Burundi", null },
                    { 27, "Cabo Verde", null },
                    { 28, "Cambodia", null },
                    { 29, "Cameroon", null },
                    { 30, "Canada", null },
                    { 31, "Central African Republic", null },
                    { 32, "Chad", null },
                    { 33, "Channel Islands", null },
                    { 34, "Chile", null },
                    { 35, "China", null },
                    { 36, "Colombia", null },
                    { 37, "Comoros", null },
                    { 38, "Congo", null },
                    { 39, "Costa Rica", null },
                    { 40, "Côte d'Ivoire", null },
                    { 41, "Croatia", null },
                    { 42, "Cuba", null },
                    { 43, "Cyprus", null },
                    { 44, "Czech Republic", null },
                    { 45, "Denmark", null },
                    { 46, "Djibouti", null },
                    { 47, "Dominica", null },
                    { 48, "Dominican Republic", null },
                    { 49, "DR Congo", null },
                    { 50, "Ecuador", null },
                    { 51, "Egypt", null },
                    { 52, "El Salvador", null },
                    { 53, "Equatorial Guinea", null },
                    { 54, "Eritrea", null },
                    { 55, "Estonia", null },
                    { 56, "Eswatini", null },
                    { 57, "Ethiopia", null },
                    { 58, "Faeroe Islands", null },
                    { 59, "Finland", null },
                    { 60, "France", null },
                    { 61, "French Guiana", null },
                    { 62, "Gabon", null },
                    { 63, "Gambia", null },
                    { 64, "Georgia", null },
                    { 65, "Germany", null },
                    { 66, "Ghana", null },
                    { 67, "Gibraltar", null },
                    { 68, "Greece", null },
                    { 69, "Grenada", null },
                    { 70, "Guatemala", null },
                    { 71, "Guinea", null },
                    { 72, "Guinea-Bissau", null },
                    { 73, "Guyana", null },
                    { 74, "Haiti", null },
                    { 75, "Holy See", null },
                    { 76, "Honduras", null },
                    { 77, "Hong Kong", null },
                    { 78, "Hungary", null },
                    { 79, "Iceland", null },
                    { 80, "India", null },
                    { 81, "Indonesia", null },
                    { 82, "Iran", null },
                    { 83, "Iraq", null },
                    { 84, "Ireland", null },
                    { 85, "Isle of Man", null },
                    { 86, "Israel", null },
                    { 87, "Italy", null },
                    { 88, "Jamaica", null },
                    { 89, "Japan", null },
                    { 90, "Jordan", null },
                    { 91, "Kazakhstan", null },
                    { 92, "Kenya", null },
                    { 93, "Kuwait", null },
                    { 94, "Kyrgyzstan", null },
                    { 95, "Laos", null },
                    { 96, "Latvia", null },
                    { 97, "Lebanon", null },
                    { 98, "Lesotho", null },
                    { 99, "Liberia", null },
                    { 100, "Libya", null },
                    { 101, "Liechtenstein", null },
                    { 102, "Lithuania", null },
                    { 103, "Luxembourg", null },
                    { 104, "Macao", null },
                    { 105, "Madagascar", null },
                    { 106, "Malawi", null },
                    { 107, "Malaysia", null },
                    { 108, "Maldives", null },
                    { 109, "Mali", null },
                    { 110, "Malta", null },
                    { 111, "Mauritania", null },
                    { 112, "Mauritius", null },
                    { 113, "Mayotte", null },
                    { 114, "Mexico", null },
                    { 115, "Moldova", null },
                    { 116, "Monaco", null },
                    { 117, "Mongolia", null },
                    { 118, "Montenegro", null },
                    { 119, "Morocco", null },
                    { 120, "Mozambique", null },
                    { 121, "Myanmar", null },
                    { 122, "Namibia", null },
                    { 123, "Nepal", null },
                    { 124, "Netherlands", null },
                    { 125, "Nicaragua", null },
                    { 126, "Niger", null },
                    { 127, "Nigeria", null },
                    { 128, "North Korea", null },
                    { 129, "North Macedonia", null },
                    { 130, "Norway", null },
                    { 131, "Oman", null },
                    { 132, "Pakistan", null },
                    { 133, "Panama", null },
                    { 134, "Paraguay", null },
                    { 135, "Peru", null },
                    { 136, "Philippines", null },
                    { 137, "Poland", null },
                    { 138, "Portugal", null },
                    { 139, "Qatar", null },
                    { 140, "Réunion", null },
                    { 141, "Romania", null },
                    { 142, "Russia", null },
                    { 143, "Rwanda", null },
                    { 144, "Saint Helena", null },
                    { 145, "Saint Kitts and Nevis", null },
                    { 146, "Saint Lucia", null },
                    { 147, "Saint Vincent and the Grenadines", null },
                    { 148, "San Marino", null },
                    { 149, "Sao Tome & Principe", null },
                    { 150, "Saudi Arabia", null },
                    { 151, "Senegal", null },
                    { 152, "Serbia", null },
                    { 153, "Seychelles", null },
                    { 154, "Sierra Leone", null },
                    { 155, "Singapore", null },
                    { 156, "Slovakia", null },
                    { 157, "Slovenia", null },
                    { 158, "Somalia", null },
                    { 159, "South Africa", null },
                    { 160, "South Korea", null },
                    { 161, "South Sudan", null },
                    { 162, "Spain", null },
                    { 163, "Sri Lanka", null },
                    { 164, "State of Palestine", null },
                    { 165, "Sudan", null },
                    { 166, "Suriname", null },
                    { 167, "Sweden", null },
                    { 168, "Switzerland", null },
                    { 169, "Syria", null },
                    { 170, "Taiwan", null },
                    { 171, "Tajikistan", null },
                    { 172, "Tanzania", null },
                    { 173, "Thailand", null },
                    { 174, "The Bahamas", null },
                    { 175, "Timor-Leste", null },
                    { 176, "Togo", null },
                    { 177, "Trinidad and Tobago", null },
                    { 178, "Tunisia", null },
                    { 179, "Turkey", null },
                    { 180, "Turkmenistan", null },
                    { 181, "Uganda", null },
                    { 182, "Ukraine", null },
                    { 183, "United Arab Emirates", null },
                    { 184, "United Kingdom", null },
                    { 185, "United States", null },
                    { 186, "Uruguay", null },
                    { 187, "Uzbekistan", null },
                    { 188, "Venezuela", null },
                    { 189, "Vietnam", null },
                    { 190, "Western Sahara", null },
                    { 191, "Yemen", null },
                    { 192, "Zambia", null },
                    { 193, "Zimbabwe", null }
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
                name: "IX_Countries_PersonId",
                table: "Countries",
                column: "PersonId");

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
                name: "IX_Persons_NationalityCountryId",
                table: "Persons",
                column: "NationalityCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Persons_ApplicationPersonId",
                table: "Applications",
                column: "ApplicationPersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Users_CreatedByUserId",
                table: "Applications",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Persons_PersonId",
                table: "Countries",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Persons_PersonId",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "DetainedLicenses");

            migrationBuilder.DropTable(
                name: "InternationalDrivingLicenses");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

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
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
