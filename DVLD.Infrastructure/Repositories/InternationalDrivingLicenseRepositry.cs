using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DVLD.Data.Repositories
{
    public class InternationalDrivingLicenseRepositry : IInternationalDrivingLicenseRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<InternationalDrivingLicense> _dbSet;
        public InternationalDrivingLicenseRepositry
            (
            ILogger logger,
            DvldContext context
            )
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.InternationalDrivingLicenses;

        }
        public async Task<bool> Add(InternationalDrivingLicense entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async Task<IEnumerable<InternationalDrivingLicense>> All(
            Expression<Func<InternationalDrivingLicense, bool>> filter = null,
            Expression<Func<InternationalDrivingLicense, object>> orderBy = null,
            bool aescending = true)
        {

            var query = _dbSet.AsNoTracking();

            if (filter is not null)
               query = query.Where(filter);
            orderBy ??= l => l.Id;

            query = aescending ? query.OrderBy(orderBy)
                              : query.OrderByDescending(orderBy);

            return await query.ToListAsync();
        }

        public Task<bool> Delete(InternationalDrivingLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<InternationalDrivingLicense?> GetById(int id)
        {
            return await _dbSet.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<User> GetCreatedByUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetDriverData(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<License> GetRasiedByLicense(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasActiveInternationaLicense(int licenseId)
        {
            var InternationalLicense = await _dbSet
                                            .FirstOrDefaultAsync(l => l.License.Id == licenseId);

            if (InternationalLicense is not null)
                return InternationalLicense.IsActive == true;

            return false;
        }

        public async Task<bool> HaveInternationalLicense(int driverId)
        {
            return await _dbSet.Where(l => l.DriverId == driverId)
                        .Select(l => l.Id)
                        .SingleOrDefaultAsync() != 0;
        }

        public Task<bool> Update(InternationalDrivingLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }
    }
}
