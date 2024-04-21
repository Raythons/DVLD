#pragma warning disable CS8618



namespace DVLD.Domain.Entities;

public class Driver 
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public User? User { get; set;}
    public ICollection<License> Licenses { get; set; }
    public InternationalDrivingLicense? InternationalDrivingLicense { get; set; }
}
