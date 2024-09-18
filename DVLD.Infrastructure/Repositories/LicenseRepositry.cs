using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DLVD.App.Features.Common;
using System.Linq.Expressions;

namespace DVLD.Data.Repositories
{
    public class LicenseRepositry : ILicenseRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private readonly DbSet<License> _dbSet;
        public LicenseRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.Licenses;

        }
        public async Task<bool> Add(License entity)
        {
            await _dbSet.AddAsync(entity);

            return true;
        }
        public Task<IEnumerable<License>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(License entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Application> GetAssociatedApplication(int licenseId)
        {
            throw new NotImplementedException();
        }



        public async Task<PagedList<TProjection>> GetAllByProjectionAsync<TProjection>(
          Expression<Func<License, TProjection>> selector,
          Expression<Func<License, bool>> filter = null,
          Expression<Func<License, object>> orderBy = null,
          bool descending = true,
          int page = 1,
          int pageSize = 2)
        {
            ArgumentNullException.ThrowIfNull(selector);
            var query = _dbSet.AsNoTracking();

            if (filter is not null)
                query = query.Where(filter);

            orderBy ??= l => l.Id;

            query = descending ? query.OrderByDescending(orderBy)
                              : query.OrderBy(orderBy);

            return await PagedList<TProjection>.CreateAsync(query.Select(selector), page, pageSize);
        }
        public Task<Driver> GetAssociatedDriver(string licenseId)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense> GetAssociatedInternationalDrivingLicense(int licenseId)
        {
            throw new NotImplementedException();
        }

        public Task<License> GetAssociatedLicense(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetAssosiatedDriver(int licenseId)
        {
            throw new NotImplementedException();
        }

        public async Task<License?> GetById(int id)
        {
            var FoundedLicense = await _dbSet
                        .Include(l => l.Driver.Person)
                        .Include(l => l.LicenseClass)
                        .FirstOrDefaultAsync(x => x.Id == id);
            return FoundedLicense;
        }

        public Task<IEnumerable<DetainedLicense?>> GetDetainedLicenses()
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int licenseId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetRaisedByUser(int licenseId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(License entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int licenseId)
        {
            throw new NotImplementedException();
        }

        public async Task<DateTime> GetExpirationDate(int licenseId)
        {
            var ExpirationDate = await _dbSet
                                        .Where(l => l.Id == licenseId)
                                        .Select(l => l.ExpirationDate)
                                        .SingleOrDefaultAsync();
            return ExpirationDate;
          
        }

        public async Task DeActivateLicense(int licenseId)
        {
            await _dbSet.Where(l => l.Id == licenseId)
                       .ExecuteUpdateAsync(l => l.SetProperty(l => l.IsActive, false));
        }

        public async Task<bool> IsActiveLicense(int licenseId)
        {
            return await _dbSet.Where(l => l.Id == licenseId)
                         .Select(l => l.IsActive)
                         .SingleOrDefaultAsync();
        }

        public Task<PagedList<License>> GetAllPaginatedAsync(Expression<Func<License, bool>> filter = null, Expression<Func<License, object>> orderBy = null, bool descending = true, int page = 1, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

       
    }
}
