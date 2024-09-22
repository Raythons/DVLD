using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DLVD.App.Features.Common;
using DVLD.Domain.Entities.Views;
using System.Linq.Expressions;
using DVLD.Domain.Enums;

namespace DVLD.Data.Repositories
{
    public class DetainedLicenseRepositry : IDetainedLicenseRepositry
    {
        protected readonly ILogger _logger;

        private DvldContext _DvldContext;
        private DbSet<DetainedLicense> _dbSet;
        public DetainedLicenseRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.DetainedLicenses;
        }
        public async Task<bool> Add(DetainedLicense entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }
        public async Task<TProjection> GetByLicenseId<TProjection>(int licenseId,
            Expression<Func<DetainedLicense, TProjection>> selector)
        {
            ArgumentNullException.ThrowIfNull(selector);

            var ProjectedValue = await _dbSet
                                        .Where(l => l.LicenseId == licenseId)
                                        .OrderByDescending(l => l.DetainDate)
                                        .Select(selector)
                                        .FirstOrDefaultAsync();
            return ProjectedValue;

        }
        public async Task<PagedList<DetainedLicenseView>> GetAllPaginatedAsync(
            Expression<Func<DetainedLicenseView, bool>> filter = null,
            Expression<Func<DetainedLicenseView, object>> orderBy = null,
            bool descending = true,
            int page = 1,
            int pageSize = 20)
        {
            var query = _DvldContext.DetainedLicenseView.AsNoTracking();

            if (filter is not null)
                query = query.Where(filter);

            orderBy ??= l => l.Id;

            query = descending ? query.OrderByDescending(orderBy)
                              : query.OrderBy(orderBy);

            return await PagedList<DetainedLicenseView>.CreateAsync(query, page, pageSize);

        }

        public async Task<bool> IsDetained(int licenseId)
        {
            var IsReleased = await _dbSet 
                                    .Where(dl => dl.LicenseId == licenseId)
                                    .OrderByDescending(dl => dl.DetainDate)
                                    .Select(dl => dl.IsReleased)
                                    .FirstOrDefaultAsync();
            return !IsReleased;
        }

        public Task<bool> Delete(DetainedLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DetainedLicense> GetAssociatedLicense(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetAssosiatedPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<DetainedLicense?> GetById(int licenseId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetCreatedByUser(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetDetainedByUser(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense()
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetReleasedByUser(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAssociatedWithLicense(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DetainedLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }

        //await _dbSet.Where(l => l.LocalDrivingLicenseApplication.Id == localDrivvingLicensesApplicationId)
        //
        //         .ExecuteUpdateAsync(s => s.SetProperty(a => a.Status, EnStatus.Canceled));
        
        public async Task<bool> ReleaseLicense(int licenseId, int releasedByUser)
        {
            await _dbSet.Where(dl => dl.LicenseId == licenseId)
                       .ExecuteUpdateAsync(s => 
                        s.SetProperty(a => a.ReleasedByUserId, releasedByUser)
                        .SetProperty(a => a.IsReleased, true)
                        .SetProperty(a => a.ReleaseDate, DateTime.Now)
                        );
             return true;           
        }

      
    }
}
