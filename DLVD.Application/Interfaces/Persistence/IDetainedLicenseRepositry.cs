using DVLD.Domain.Entities;

namespace DVLD.App.Interfaces.Persistence
{
    public interface IDetainedLicenseRepositry
    {
        public Task<IEnumerable<DetainedLicense>> All();
        public Task<DetainedLicense?> GetById(int id);
        public Task<bool> Add(DetainedLicense entity);
        public Task<bool> Update(DetainedLicense entity);
        public Task<bool> Update(int driverId);
        public Task<bool> Delete(DetainedLicense entity);
        public Task<bool> DeleteById(int id);
        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense();
        public Task<bool> IsAssociatedWithLicense(int applicatonId);
        public Task<DetainedLicense> GetAssociatedLicense(int applicatonId);
        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId);
        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId);
        public Task<User> GetCreatedByUser(int driverId);
        public Task<User> GetDetainedByUser(int driverId);
        public Task<User> GetReleasedByUser(int driverId);
        public Task<Person> GetAssosiatedPerson(int Id);
    }
}
