using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLVD.App.Features.Common.SharedDtos;

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

        public Task<Person> GetAssosiatedPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Driver?> GetById(int id)

        {


        //public int Id { get; set; }
        //public int PersonId { get; set; }
        //public int CreatedByUserId { get; set; }
        //public string NationalNo { get; set; }
        //public string FullName { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public string ActiveLicense { get; set; }

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
            GetDriverDto

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

