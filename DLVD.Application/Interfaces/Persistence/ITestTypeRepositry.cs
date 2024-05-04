using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ITestTypeRepositry
    {
        public Task<IEnumerable<object>> All();
        public Task<short> GetTypesCount();
        public Task<TestType?> GetById(int testTypeId);
        public Task<bool> Add(TestType entity);
        public Task<bool> Update(TestType entity);
        public Task<bool> Update(int testTypeId);
        public Task<bool> Delete(TestType entity);
        public Task<bool> DeleteById(int testTypeId);
        public Task<IEnumerable<Test>> GetTests(int testTypeId);
        public Task<int> GetTestsCount(int testTypeId);
        public Task<IEnumerable<TestAppointment>> GetTestAppoinments(Test test);



    }
}
