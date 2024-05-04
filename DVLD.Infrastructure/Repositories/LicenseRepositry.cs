using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            var FoundedLicense = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
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
    }
}
