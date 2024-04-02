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
    public class DetainedLicenseRepositry : IDetainedLicenseRepositry
    {
        protected readonly ILogger _logger;

        private DvldContext _DvldContext;
        public DetainedLicenseRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
        }
        public Task<bool> Add(DetainedLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetainedLicense>> All()
        {
            throw new NotImplementedException();
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

        public Task<DetainedLicense?> GetById(int id)
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
    }
}
