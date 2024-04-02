using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DVLD.App.Interfaces.Persistence
{
    public interface IApplicationTypeRepositry
    {
        public Task<IEnumerable<object>> All();
        public Task<float> GetApplicationTypeFees(int typeId);
        public Task<ApplicationType?> GetById(int id);
        public Task<bool> Add(ApplicationType entity);
        public Task<bool> Update(ApplicationType entity);
        public Task<bool> Update(int driverId);
        public Task<bool> Delete(ApplicationType entity);
        public Task<bool> DeleteById(int id);
        public Task<IEnumerable<Application>> GetApplicationsByType(int applicationTypeId);
    }
}
