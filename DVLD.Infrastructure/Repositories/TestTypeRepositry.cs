using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DVLD.Domain;


namespace DVLD.Data.Repositories
{
    public class TestTypeRepositry : ITestTypeRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<TestType> _dbSet;
        public TestTypeRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.TestTypes;

        }
       
        public Task<bool> Add(TestType entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<object>> All()
        {
            var Types = await _DvldContext.TestTypes
                .Where(x => true)
                .Select(x => new {
                    x.Id,
                    x.TestTypeTitle ,
                    x.TestTypeDescription,
                    x.TestTypeFees
                }
                )
                .ToListAsync();

            return Types;
        }

        public Task<bool> Delete(TestType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int testTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<TestType?> GetById(int testTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TestAppointment>> GetTestAppoinments(Test test)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Test>> GetTests(int testTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTestsCount(int testTypeId)
        {
            throw new NotImplementedException();
        }

        public async Task<short> GetTypesCount()
        {
            return (short) await _dbSet.CountAsync();
        }

        public Task<bool> Update(TestType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int testTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
