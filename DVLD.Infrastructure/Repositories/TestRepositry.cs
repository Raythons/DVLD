using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Data.Repositories
{
    public class TestRepositry : ITestRepositry
    {
        protected readonly ILogger _logger;

        private DvldContext _DvldContext;
        public TestRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
        }
        public Task<bool> Add(Test entity)
        {
            throw new NotImplementedException();
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

        public Task<Test?> GetById(int testId)
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
