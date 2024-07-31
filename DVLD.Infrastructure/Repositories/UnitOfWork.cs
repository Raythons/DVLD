using DLVD.App.Interfaces.Persistence;
using DVLD.App.Interfaces.Persistence;
using DVLD.Infrastructure.Repositories;
using Microsoft.Extensions.Logging;


namespace DVLD.Data.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DvldContext _context;
    private readonly ILogger _logger;

    public IApplicationRepositry ApplicationRepositry { get; }

    public IApplicationTypeRepositry ApplicationTypeRepositry { get; }

    public ICountryRepository CountryRepository { get; }

    public IDetainedLicenseRepositry DetainedLicenseRepositry { get; }

    public IDriverRepository DriverRepository { get; }

    public IInternationalDrivingLicenseRepositry InternationalDrivingLicenseRepositry { get; }

    public ILicenseClassRepositry LicenseClassRepositry { get; }

    public ILicenseRepositry LicenseRepositry { get; }

    public ILocalDrivingLicenseApplicationRepositry LocalDrivingLicenseApplicationRepositry { get; }

    public IPersonRepository PersonRepository { get; }

    public ITestAppointmentRepositry TestAppointmentRepositry { get; }

    public ITestRepositry TestRepositry { get; }

    public ITestTypeRepositry TestTypeRepositry { get; }

    public IUserRepository UserRepository { get; }
    public IRefreshTokenRepositry RefreshTokenRepositry { get; }

    public UnitOfWork(DvldContext context, ILoggerFactory loggerFactory)
    {
        _context = context;
         _logger = loggerFactory.CreateLogger<UnitOfWork>();

        ApplicationRepositry = new ApplicationRepositry(_logger, context);
        ApplicationTypeRepositry = new ApplicationTypeRepositry(_logger, context);
        CountryRepository = new CountryRepositry(_logger, context);
        DetainedLicenseRepositry = new DetainedLicenseRepositry(_logger, context);
        DriverRepository = new DriverRepositry(_logger, context); 
        InternationalDrivingLicenseRepositry = new InternationalDrivingLicenseRepositry(_logger, context);
        LicenseClassRepositry = new LicenseClassRepositry(_logger, context);
        LicenseRepositry = new LicenseRepositry(_logger, context);
        LocalDrivingLicenseApplicationRepositry = new LocalDrivingLicenseApplicationRepositry(_logger, context);
        PersonRepository = new PersonRepositry(_logger, context);
        TestAppointmentRepositry = new TestAppointmentRepositry(_logger, context);
        TestRepositry = new TestRepositry(_logger, context);
        TestAppointmentRepositry = new TestAppointmentRepositry(_logger, context);
        TestTypeRepositry = new TestTypeRepositry(_logger, context);
        UserRepository = new UserRepository(_logger, context);
        RefreshTokenRepositry = new RefreshTokenRepositry(_logger, context);
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
        _context.
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task StartTrancation()
    {
        await _context.Database.BeginTransactionAsync();
    }
    public async Task RoleBack()
    {
        await _context.Database.RollbackTransactionAsync();
    }

    public async Task CommitTrancation()
    {
        await _context.Database.CommitTransactionAsync();
    }
}
