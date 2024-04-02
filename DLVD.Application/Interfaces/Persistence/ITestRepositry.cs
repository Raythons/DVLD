using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ITestRepositry
    {

        public Task<IEnumerable<Test>> All();
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
