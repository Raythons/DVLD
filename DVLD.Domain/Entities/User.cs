#pragma warning disable CS8618


using DVLD.Domain.Entities;

namespace DVLD.Domain.Entities;

public class User 
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; }
    public ICollection<Driver>? DriversCreated { get; set; }
    public ICollection<Application>? ApplicationsCreated { get; set; }
    public ICollection<License>? LicensesCreated { get; set; }
    public ICollection<DetainedLicense>? DetainedLicensesReleased { get; set; }
    public ICollection<DetainedLicense>? DetainedLicensesCreated { get; set; }
    public ICollection<InternationalDrivingLicense>? InternationalDLAsCreated { get; set; }
    public ICollection<Test>? TestsCreated { get; set; }
    public ICollection<TestAppointment>? TestAppointmentsCreated { get; set; }
}
