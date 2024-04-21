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
    internal class LicenseClassRepositry : ILicenseClassRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private readonly DbSet<LicenseClass> _dbSet;
        public LicenseClassRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.LicenseClasses;

        }
        public Task<bool> Add(LicenseClass entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LicenseClass>> All()
        {
            return  await _dbSet.Where(x => true).ToListAsync();
        }

        public Task<bool> Delete(LicenseClass entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int LicenseClassId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<License>> GetAssociatedLicenses(int LicenseClassId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetAssociatedLocalDrivingLicenseApplications()
        {
            throw new NotImplementedException();
        }

        public Task<LicenseClass?> GetById(int LicenseClassId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Application entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int LicenseClassId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetLicenseExpirationYears(int licenseClassId)
        {
            var licenseClass = await _dbSet
                            .SingleOrDefaultAsync(l => l.Id == licenseClassId);


            return licenseClass.DefaultValidityLength;
        }
    }
}
