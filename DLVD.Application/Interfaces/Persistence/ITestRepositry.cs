using DVLD.Domain.Entities;


namespace DVLD.App.Interfaces.Persistence
{
    public interface ITestRepositry
    {
        public Task<IEnumerable<Test>> All();
        public Task<bool> HasFailedTest(int applicationId);
        public Task<bool> HasPassedTestOfType(int applicationId, int testTypeId);
        public Task<Test?> GetById(int testId);
        public Task<bool> Add(Test entity);
        public Task<bool> Update(Test entity);
        public Task<bool> Update(int testId);
        public Task<bool> Delete(Test entity);
        public Task<bool> DeleteById(int testId);
        public Task<User> GetCreatedByUser(int testId);
        public Task<TestAppointment> GetTestAppointment(int testId);
    }
}
