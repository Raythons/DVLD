using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Data.Repositories
{
    public class LicenseRepositry : ILicenseRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        public LicenseRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;

        }
        public Task<bool> Add(License entity)
        {
            throw new NotImplementedException();
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

        public Task<License?> GetById(int id)
        {
            throw new NotImplementedException();
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
    }
}
