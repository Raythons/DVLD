namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDriverLicense
{
    public class GetLocalDrivvingLicenseDto
    {
        
        public int Id { get; set; }
        public string LicenseClass { get; set; }
        public short PassedTests { get; set; }
        public short TestsCount { get; set; } = 3;

        
        public GetLocalDrivvingLicenseDto() { }
        public GetLocalDrivvingLicenseDto(int id, string licenseClass, short passedTests)
        {
            Id = id;
            LicenseClass = licenseClass;
            PassedTests = passedTests;
        }

    }
}