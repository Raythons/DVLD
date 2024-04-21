using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ITestAppointmentRepositry
    {
        public Task<IEnumerable<TestAppointment>> All();
        public Task<bool> HasActiveTestAppointment(int LocalDrivingLicenseApplicationId);
        public Task LockTestAppoitnment(int testAppointmentId);
        public Task<TestAppointment?> GetById(int id);
        public Task<bool> Add(TestAppointment entity);
        public Task<bool> Update(TestAppointment entity);
        public Task<bool> Update(int driverId);
        public Task<bool> Delete(TestAppointment entity);
        public Task<bool> DeleteById(int id);
        public Task<TestType> GetTestType(int testId);
        public Task<Test> GetTest(int testId);
        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense();
        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId);

        public Task<User> GetCreatedByUser(int driverId);
    }
}
