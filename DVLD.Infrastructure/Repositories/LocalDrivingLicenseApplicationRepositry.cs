using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain;
using DVLD.Domain.Entities;
using DVLD.Domain.Entities.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace DVLD.Data.Repositories
{
    public class LocalDrivingLicenseApplicationRepositry : ILocalDrivingLicenseApplicationRepositry
    {

        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<LocalDrivingLicenseApplication> _dbSet;
        public LocalDrivingLicenseApplicationRepositry(
            ILogger logger,
            DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = context.LocalDrivingLicenseApplications;

        }
        public async Task<bool> Add(LocalDrivingLicenseApplication entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async Task<IEnumerable<LocalDrivvingLicenseApplicationsView>> All()
        {
            return await _DvldContext.LocalDrivvingLicenseApplicationsView.ToListAsync();
        }    
        public Task<bool> Delete(LocalDrivingLicenseApplication entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<TProjection>> GetAllByProjectionAsync<TProjection>(
            Expression<Func<LocalDrivingLicenseApplication, TProjection>> selector,
            Expression<Func<LocalDrivingLicenseApplication, bool>> filter = null,
            Expression<Func<LocalDrivingLicenseApplication, object>> orderBy  = null,
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

        public async Task<PagedList<LocalDrivvingLicenseApplicationsView>> GetAllPaginatedAsync(
            Expression<Func<LocalDrivvingLicenseApplicationsView, bool>> filter = null,
            Expression<Func<LocalDrivvingLicenseApplicationsView, object>> orderBy = null,
            bool descending = true,
            int page = 1,
            int pageSize = 20)
        {
            var query = _DvldContext.LocalDrivvingLicenseApplicationsView.AsNoTracking();

            if (filter is not null)
                query = query.Where(filter);

            orderBy ??= l => l.Id;

            query = descending ? query.OrderByDescending(orderBy)
                              : query.OrderBy(orderBy);

            return await PagedList<LocalDrivvingLicenseApplicationsView>.CreateAsync(query, page, pageSize);
        }

        public async Task<int> GetApplicationId (int LocalDrivvingLicenseApplicationId)
        {
            return await _dbSet.Where(x => x.Id == LocalDrivvingLicenseApplicationId)
                    .Select(x => x.ApplicationId)
                    .SingleOrDefaultAsync();
        }
        public Task<Application> GetAssociatedApplication(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<License>> GetAssociatedLicenseClass(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetAssociatedLocalDrivingLicenseApplications()
        {
            throw new NotImplementedException();
        }

        public async Task<LocalDrivingLicenseApplication?> GetById(int id)
        {
            return await _dbSet.Include(x => x.LicenseClass).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetPaginated(int Page)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TestAppointment?>> GetTestAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasPassedAllTests(int localDrivingLicenseApplicationId)
        {
            var testAppointments = _dbSet
                .Where(a => a.Id == localDrivingLicenseApplicationId)
                .Include(a => a.TestAppointments)
                .SelectMany(a => a.TestAppointments);

                

            var passedTestsCount =  await testAppointments
                 .CountAsync(ta => ta.Test != null && ta.Test.TestResult == EnTestResult.Pass);
                

            return passedTestsCount >= 3;

        }

        public Task<bool> Update(LocalDrivingLicenseApplication entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
