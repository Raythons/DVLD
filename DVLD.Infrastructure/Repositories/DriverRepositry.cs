using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Data.Repositories
{
    public class DriverRepositry : IDriverRepository
    {

        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        public DriverRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;

        }
        public Task<bool> Add(Driver entity)
        {
            throw new NotImplementedException();
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

        public Task<Driver?> GetById(int id)
        {
            throw new NotImplementedException();
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

