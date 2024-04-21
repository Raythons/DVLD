using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ILocalDrivingLicenseApplicationRepositry
    {
        public Task<IEnumerable<LocalDrivingLicenseApplication>> All();
        public Task<bool> HasPassedAllTests(int LocalDrivingLicenseApplicationId);

        public Task<LocalDrivingLicenseApplication?> GetById(int LocalDrivingLicenseApplicationId);
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
