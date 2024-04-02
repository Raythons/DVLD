#pragma warning disable CS8618
using DVLD.Domain.Enums;



namespace DVLD.Domain.Entities;

public class Application
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public DateTime CreatedAt { set; get; }
    public DateTime LastStatusDate { set; get; }
    public int ApplicationTypeId { get; set; }
    public ApplicationType ApplicationType { get; set; }
    public EnStatus Status { get; set; }
    public float PaidFees { set; get; }
    public int CreatedByUserId { set; get; }
    public User User { get; set; }
    public License? License { set; get; }
    public ICollection<DetainedLicense>? DetainedLicense { set; get; }
    public InternationalDrivingLicense? InternationalDrivingLicenseApplication { set; get; }
    public LocalDrivingLicenseApplication? LocalDrivingLicenseApplication { get; set; }
}
