using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DVLD.Domain;

namespace DVLD.Data.Repositories
{
    public class LocalDrivingLicenseApplicationRepositry : ILocalDrivingLicenseApplicationRepositry
    {

        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<LocalDrivingLicenseApplication> _dbSet;
        public LocalDrivingLicenseApplicationRepositry(
            ILogger logger,
            DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = context.LocalDrivingLicenseApplications;

        }
     
    
        public async Task<bool> Add(LocalDrivingLicenseApplication entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }


        public Task<IEnumerable<LocalDrivingLicenseApplication>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(LocalDrivingLicenseApplication entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Application> GetAssociatedApplication(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<License>> GetAssociatedLicenseClass(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetAssociatedLocalDrivingLicenseApplications()
        {
            throw new NotImplementedException();
        }

        public async Task<LocalDrivingLicenseApplication?> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<IEnumerable<TestAppointment?>> GetTestAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasPassedAllTests(int localDrivingLicenseApplicationId)
        {
            var testAppointments = _dbSet
                .Where(a => a.Id == localDrivingLicenseApplicationId)
                .Include(a => a.TestAppointments)
                .SelectMany(a => a.TestAppointments);

                

            var passedTestsCount =  await testAppointments
                 .CountAsync(ta => ta.Test != null && ta.Test.TestResult == EnTestResult.Pass);
                

            return passedTestsCount >= 3;

        }

        public Task<bool> Update(LocalDrivingLicenseApplication entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
