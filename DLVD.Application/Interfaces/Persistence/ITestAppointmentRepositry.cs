using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ITestAppointmentRepositry
    {
        public Task<IEnumerable<TestAppointment>> All();
        public  Task<PagedList<TProjection>> GetAllByProjectionAsync<TProjection>(
         Expression<Func<TestAppointment, TProjection>> selector,
         Expression<Func<TestAppointment, bool>> filter = null,
         Expression<Func<TestAppointment, object>> orderBy = null,
         bool descending = true,
         int page = 1,
         int pageSize = 20);
        public Task<bool> HasActiveTestAppointment(int LocalDrivingLicenseApplicationId);
        public Task LockTestAppoitnment(int testAppointmentId);
        public Task<TestAppointment?> GetById(int id);
        public Task<bool> Add(TestAppointment entity);
        public Task<bool> Update(TestAppointment entity);
        public Task<bool> UpdateDate(int testAppointmentId, DateTime newTestDate);
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
