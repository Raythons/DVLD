using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using System.Linq.Expressions;


namespace DVLD.App.Interfaces.Persistence
{
    public interface ILicenseRepositry
    {
        // WE Will Never Use This Just In The Begining
        public Task<IEnumerable<License>> All();
        public Task<int> GetLicenseIdByApplicationId(int applicationId);
        public Task<int> GetLicenseClassId(int licenseId);
        public Task<int> GetDriverIdByLicenseId(int licenseId);
        public Task DeActivateLicense(int licenseId);
        public Task<License?> GetById(int id);
        public Task<bool> Add(License entity);

        public Task<PagedList<License>> GetAllPaginatedAsync(
           Expression<Func<License, bool>> filter = null,
           Expression<Func<License, object>> orderBy = null,
           bool descending = true,
           int page = 1,
           int pageSize = 20);

        Task<PagedList<TProjection>> GetAllByProjectionAsync<TProjection>(
          Expression<Func<License, TProjection>> selector,
          Expression<Func<License, bool>> filter = null,
          Expression<Func<License, object>> orderBy = null,
          bool descending = true,
          int page = 1,
          int pageSize = 20);
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
        public Task<DateTime> GetExpirationDate(int licenseId);
        public Task<bool> IsActiveLicense(int licenseId);
    }
}
