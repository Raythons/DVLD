using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DLVD.App.Features.Common;
using System.Linq.Expressions;
using DVLD.Domain.Entities.Views;

namespace DVLD.Data.Repositories
{
    public class DriverRepositry : IDriverRepository
    {

        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<Driver> _dbSet;
        public DriverRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.Drivers;

        }
        public async Task<bool> Add(Driver entity)
        {
            await _dbSet.AddAsync(entity);

            return true;
        }

        public Task<IEnumerable<Driver>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<DriversBreifInfoView>> GetAllPaginatedAsync(
            Expression<Func<DriversBreifInfoView, bool>> filter = null,
            Expression<Func<DriversBreifInfoView, object>> orderBy = null,
            bool descending = true,
            int page = 1,
            int pageSize = 20)
        {
            var query = _DvldContext.DriversBreifInfoView.AsNoTracking();

            if (filter is not null)
                query = query.Where(filter);

            orderBy ??= d => d.DriverId;

            query = descending ? query.OrderByDescending(orderBy)
                              : query.OrderBy(orderBy);

            return await PagedList<DriversBreifInfoView>.CreateAsync(query, page, pageSize);
        }

        public Task<Person> GetAssosiatedPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Driver?> GetById(int id)
        {
        var Driver =  _dbSet
                                    .AsNoTracking()
                                    .Join(_DvldContext.Persons,
                                        d => d.PersonId,
                                        p => p.Id,
                                        (d, p) =>  new
                                            {
                                                d.Id,
                                                d.PersonId,
                                                FullName = p.FirstName + " " + p.SecondName + " " + p.ThirdName + " " + p.LastName,
                                            }
                                        );
            

            var FoundedDriver = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            return FoundedDriver;
        }

        public Task<User> GetCreatedByUser(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<InternationalDrivingLicense> GetInternationalDrivingLicense()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }
    }
}

