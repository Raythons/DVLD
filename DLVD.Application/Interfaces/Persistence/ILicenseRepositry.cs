using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ILicenseRepositry
    {
        // WE Will Never Use This Just In The Begining
        public Task<IEnumerable<License>> All();
        public Task<License?> GetById(int id);
        public Task<bool> Add(License entity);
        public Task<bool> Update(License entity);
        public Task<bool> Update(int licenseId);
        public Task<bool> Delete(License entity);
        public Task<bool> DeleteById(int id);
        public Task<Application> GetAssociatedApplication(int licenseId);
        public Task<Driver> GetAssociatedDriver(string licenseId);
        public Task<InternationalDrivingLicense> GetAssociatedInternationalDrivingLicense(int licenseId);

        //public Task<bool> IsAssociatedWithLicense(int applicatonId);
        public Task<License> GetAssociatedLicense(int applicatonId);
        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int licenseId);
        public Task<IEnumerable<DetainedLicense?>> GetDetainedLicenses();
        public Task<User> GetRaisedByUser(int licenseId);
        public Task<Driver> GetAssosiatedDriver(int licenseId);
    }
}
