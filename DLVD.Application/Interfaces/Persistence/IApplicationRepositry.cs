using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using System.Linq.Expressions;


namespace DVLD.App.Interfaces.Persistence
{
    public interface IApplicationRepositry
    {
        public Task<Application> GetPersonLocalApplicationsOfLicenseClass(int personId, int licenseClassId);
        public Task<bool> UpdateStatus(int applicationId , EnStatus status);
        public Task<IEnumerable<Application>> All();
        public Task<Application?> GetById(int id);
        public Task<Application?> GetPersonApplications(int id);
        public Task<List<Application>> GetPaginatedAsync(
                int page,
                Expression<Func<Application, object>> sortExpression,
                string searchTearm,
                string sortOrder
                );

        public Task<bool> Add(Application entity);
        public Task<bool> Update(Application entity);
        public Task<bool> Update(int driverId);
        public Task<bool> Delete(Application entity);
        public Task<bool> DeleteById(int id);
        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense();
        public Task<bool> IsAssociatedWithLicense(int applicatonId);
        public Task<License> GetAssociatedLicense(int applicatonId);
        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId);
        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId);
        public Task<User> GetCreatedByUser(int driverId);
        public Task<Person> GetAssosiatedPerson(int Id);
    }
}
