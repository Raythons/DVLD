using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DVLD.Data.Repositories
{
    public class ApplicationTypeRepositry : IApplicationTypeRepositry
    {
        protected readonly ILogger _logger;

        private DvldContext _DvldContext;
        private DbSet<ApplicationType> _dbSet;
        public ApplicationTypeRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.ApplicationTypes;
        }

        public async Task<IEnumerable<object>> All()
        {
            var Types =await _DvldContext.ApplicationTypes
                .Where(x => true)
                .Select(x => new { x.ApplicationTypeId,
                              x.ApplicationTypeTitle,
                              x.ApplicationTypeFees
                    }
                )
                .ToListAsync();

            return Types;
        }

        public async Task<float> GetApplicationTypeFees(int typeId)
        {

            var fees = await _dbSet.Where(t => t.ApplicationTypeId == typeId)
                            .Select(t => t.ApplicationTypeFees)
                            .FirstOrDefaultAsync();

            return fees;
        }

        public Task<bool> Add(ApplicationType entity)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Delete(ApplicationType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Application>> GetApplicationsByType(int applicationTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationType?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ApplicationType entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }

      
    }
}
