#pragma warning disable CS8618


namespace DVLD.Domain.Entities;

public class LicenseClass { 
    public int Id { get; set; }
    public string ClassName { get; set; }
    public string ClassDescription { get; set; }
    public byte MinimumAllowedAge { get; set; }
    public int DefaultValidityLength { get; set; }
    public float ClassFees { get; set; }
    public ICollection<License>? Licenses { get; set; }
    public ICollection<LocalDrivingLicenseApplication>? LocalDrivingLicenseApplications { get; set; }
}