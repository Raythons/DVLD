using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DVLD.Data.Repositories
{
    public class TestAppointmentRepositry : ITestAppointmentRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<TestAppointment> _dbSet;
        public TestAppointmentRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.TestAppointments;

        }
        public async Task<TestAppointment?> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<bool> Add(TestAppointment entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }
       
        public Task<IEnumerable<TestAppointment>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(TestAppointment entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

       

        public Task<User> GetCreatedByUser(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense()
        {
            throw new NotImplementedException();
        }

        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<Test> GetTest(int testId)
        {
            throw new NotImplementedException();
        }

        public Task<TestType> GetTestType(int testId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TestAppointment entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasActiveTestAppointment(int applicationId)
        {
            var hasActiveAppointment = _dbSet
                                        .AnyAsync(T => T.LocalDrivingLicenseApplicationId == 
                                            applicationId &&
                                            T.IsLocked == false);

            return hasActiveAppointment;
        }

        public async Task LockTestAppoitnment(int testAppointmentId)
        {
            var TestAppointment = await _dbSet
                                    .FirstOrDefaultAsync(t => t.Id == testAppointmentId);

             TestAppointment.IsLocked = true;       
        }

        public async Task<bool> UpdateDate(int testAppointmentId, DateTime newTestDate)
        {
            var testAppoinment = await _dbSet
                                    .FirstOrDefaultAsync(t => t.Id == testAppointmentId);

            if (testAppoinment is null)
                    return false;    
            
            testAppoinment.AppointmentDate = newTestDate;
            return true;
            
        }
    }
}
