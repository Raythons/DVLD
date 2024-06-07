#pragma warning disable CS8618


namespace DVLD.Domain.Entities;

public class DetainedLicense 
{
    public int Id { get; set; }
    public int LicenseId { get; set; }
    public License License { get; set; }
    public DateTime DetainDate { get; set; }
    public float FineFees { get; set; }
    public int CreatedByUserId { get; set; }
    public User CreateUser { get; set; }
    public bool IsReleased { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int ReleasedByUserId { get; set; }
    public User? ReleasedByUser { get; set; }
    public int ReleaseApplicationId { get; set; } 
    public Application? Application { get; set; }
}
