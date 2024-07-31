using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DVLD.Domain;

namespace DVLD.Data.Repositories
{
    public class TestRepositry : ITestRepositry
    {
        protected readonly ILogger _logger;

        private readonly DvldContext _DvldContext;
        private readonly DbSet<Test> _dbSet;
        public TestRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.Tests;
        }
        
        public async Task<bool> Add(Test entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async Task<Test?> GetById(int testId)
        {
            var FoundedTest = await _dbSet.FirstOrDefaultAsync(x => x.Id == testId);

            return FoundedTest;
        }
        public async Task<bool> HasPassedTestOfType(int applicationId, int testTypeId)
        {

            var hasPassedTest = await _dbSet
                                      .Include(t => t.TestAppointment)
                                      .AnyAsync(t => t
                                                     .TestAppointment
                                                     .LocalDrivingLicenseApplicationId == applicationId
                                                     && t.TestAppointment.TestTypeId == testTypeId
                                                        && t.TestResult == EnTestResult.Pass);


            return hasPassedTest;
        }
        public async Task<bool> HasFailedTest(int applicationId)
        {

            var hasFailedTest = await _dbSet
                                      .Include(t => t.TestAppointment)
                                      .AnyAsync(t => t.TestAppointment
                                                     .LocalDrivingLicenseApplicationId == applicationId
                                                 && t.TestResult == EnTestResult.Fail);

            return hasFailedTest;
        }


        public Task<IEnumerable<Test>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Test entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int testId)
        {
            throw new NotImplementedException();
        }

     
        public Task<User> GetCreatedByUser(int testId)
        {
            throw new NotImplementedException();
        }

        public Task<TestAppointment> GetTestAppointment(int testId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Test entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int testId)
        {
            throw new NotImplementedException();
        }
    }
}
