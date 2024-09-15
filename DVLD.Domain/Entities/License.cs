#pragma warning disable CS8618

using DVLD.Domain.Enums;

namespace DVLD.Domain.Entities;

public class License 
{
    public int Id { get; set; }
    public int ApplicationId { get; set; }
    public Application Application { get; set; }
    public int DriverId { get; set; }
    public Driver Driver { get; set; }
    public int LicenseClassId { get; set; }
    public LicenseClass LicenseClass { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Notes { get; set; }
    public float PaidFees { get; set; }
    public bool IsActive { get; set; } = true;
    public string IssueReason { get; set; }
    public int CreatedByUserId { get; set; }
    public User User { get; set; }
    public ICollection<DetainedLicense>? DetainedLicense { get; set; }
    public InternationalDrivingLicense? InternationalDrivingLicense { get; set; }
}
