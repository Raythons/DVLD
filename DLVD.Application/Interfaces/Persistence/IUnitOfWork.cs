using DLVD.App.Interfaces.Persistence;

namespace DVLD.App.Interfaces.Persistence;

public interface IUnitOfWork
{
    IApplicationRepositry ApplicationRepositry { get; }
    IApplicationTypeRepositry ApplicationTypeRepositry { get; }
    ICountryRepository CountryRepository { get; }
    IDetainedLicenseRepositry DetainedLicenseRepositry { get; }
    IDriverRepository DriverRepository { get; }
    IInternationalDrivingLicenseRepositry InternationalDrivingLicenseRepositry { get; }
    ILicenseClassRepositry LicenseClassRepositry { get; }
    ILicenseRepositry LicenseRepositry { get; }
    ILocalDrivingLicenseApplicationRepositry LocalDrivingLicenseApplicationRepositry { get; }
    IPersonRepository PersonRepository { get; }
    ITestAppointmentRepositry TestAppointmentRepositry { get; }
    ITestRepositry TestRepositry { get; }
    ITestTypeRepositry TestTypeRepositry { get; }
    IUserRepository UserRepository { get; }
    IRefreshTokenRepositry RefreshTokenRepositry { get; }
    Task CompleteAsync();
}
