using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using DVLD.Domain.Entities.Views;
using System.Linq.Expressions;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ILocalDrivingLicenseApplicationRepositry
    {
        public Task<IEnumerable<LocalDrivvingLicenseApplicationsView>> All();
        public Task<bool> HasPassedAllTests(int LocalDrivingLicenseApplicationId);
        public  Task<int> GetApplicationId(int LocalDrivvingLicenseApplicationId);
        public Task<int> GetApplicantId(int LocalDrivvingLicenseApplicationId);

       public Task<PagedList<LocalDrivvingLicenseApplicationsView>> GetAllPaginatedAsync(
       Expression<Func<LocalDrivvingLicenseApplicationsView, bool>> filter = null,
       Expression<Func<LocalDrivvingLicenseApplicationsView, object>> orderBy = null,
       bool descending = true,
       int page = 1,
       int pageSize = 20);

        Task<PagedList<TProjection>> GetAllByProjectionAsync<TProjection>(
        Expression<Func<LocalDrivingLicenseApplication, TProjection>> selector,
        Expression<Func<LocalDrivingLicenseApplication, bool>> filter = null,
        Expression<Func<LocalDrivingLicenseApplication, object>> orderBy = null,
        bool descending = true,
        int page = 1,
        int pageSize = 20);

        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetPaginated(int Page);
        public Task<LocalDrivingLicenseApplication?> GetById(int LocalDrivingLicenseApplicationId);
        public Task<int> GetLicenseClassId (int LocalDrivingLicenseApplicationId);
        public Task<bool> Add(LocalDrivingLicenseApplication entity);
        public Task<bool> Update(LocalDrivingLicenseApplication entity);
        public Task<bool> Update(int id);
        public Task<bool> Delete(LocalDrivingLicenseApplication entity);
        public Task<bool> DeleteById(int id);
        public Task<Application> GetAssociatedApplication(int LocalDrivingLicenseApplicationId);
        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetAssociatedLocalDrivingLicenseApplications();
        public Task<IEnumerable<License>> GetAssociatedLicenseClass(int id);
        public Task<IEnumerable<TestAppointment?>> GetTestAppointment(int id);

    }
}
