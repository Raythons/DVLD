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
    public class InternationalDrivingLicenseRepositry : IInternationalDrivingLicenseRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        public InternationalDrivingLicenseRepositry
            (
            ILogger logger,
            DvldContext context
            )
        {
            _logger = logger;
            _DvldContext = context;

        }
        public Task<bool> Add(InternationalDrivingLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InternationalDrivingLicense>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(InternationalDrivingLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense?> GetById(int id)
        {
            throw new NotImplementedException();
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
