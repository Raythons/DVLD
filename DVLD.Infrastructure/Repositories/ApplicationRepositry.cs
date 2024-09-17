using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using DLVD.App.extensions;
using DVLD.Domain.Enums;

namespace DVLD.Data.Repositories
{
    public class ApplicationRepositry : IApplicationRepositry
    {
        protected readonly ILogger _logger;

        private readonly DvldContext _DvldContext;
        private readonly DbSet<Application> _dbSet;

        public ApplicationRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.Applications;
        }

        public async Task<Application?> GetById(int id)
        {
            var res = await _dbSet
                                .Include(a => a.Person)
                                .Include(a => a.User)
                                .Include(a => a.ApplicationType)
                                .FirstOrDefaultAsync(a => a.Id == id);

            return res;
        }
        public async Task<List<Application>> GetPaginatedAsync(
                                    int page,
                                    Expression<Func<Application, object>> sortExpression,
                                    string searchTerm,
                                    string sortOrder)
        {
            IQueryable<Application> PaginatedApplications = _dbSet;

            PaginatedApplications = PaginatedApplications
                .Select
                (app => new Application()
                {
                    Id = app.Id,
                    PersonId = app.PersonId,
                    Person = new Person
                    {
                        FirstName = app.Person.FirstName,
                        SecondName = app.Person.SecondName,
                        ThirdName = app.Person.ThirdName,
                        LastName = app.Person.LastName
                    },
                    CreatedAt = app.CreatedAt,
                    ApplicationTypeId = app.ApplicationTypeId,
                    Status = app.Status,
                    LastStatusDate = app.LastStatusDate,
                    PaidFees = app.PaidFees,
                    CreatedByUserId = app.CreatedByUserId
                }
                );

            if (!string.IsNullOrEmpty(searchTerm))
            {
                PaginatedApplications = PaginatedApplications
                                         .Where(u =>
                                         u.Person.FirstName.Contains(searchTerm) ||
                                         u.Person.SecondName.Contains(searchTerm) ||
                                         u.Person.ThirdName.Contains(searchTerm) ||
                                         u.Person.LastName.Contains(searchTerm));
            }

            PaginatedApplications = PaginatedApplications.
                                    ApplySorting(sortOrder,
                                                sortExpression
                                                ).Skip((page - 1) * 20)
                                                .Take(20);

            return await PaginatedApplications.ToListAsync();
        }

        public async Task<IEnumerable<Application>> All()
        {
            var res = await _dbSet.Select(a => a).ToListAsync();

            return res;
        }

        public async Task<bool> Add(Application entity)
        {
            await _dbSet.AddAsync(entity);

            return true;
        }
        public Task<bool> Delete(Application entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteById(int id)
        {
            var application = await _dbSet.FirstOrDefaultAsync(a => a.Id == id);

            application.Status = EnStatus.Canceled;

            return true;
        }

        public Task<License> GetAssociatedLicense(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetAssosiatedPerson(int Id)
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

        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public Task<LocalDrivingLicenseApplication> GetLocalDrivingLicenseApplication(int applicatonId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsAssociatedWithLicense(int applicatonId)
        {
            var License = await _dbSet.Where(a => a.Id == applicatonId)
                                .Select(a => a.License)
                                .SingleOrDefaultAsync();
            if (License is null)
                return false;
            return true;
        }

        public Task<bool> Update(Application entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Application>> AllApplicationOfUser()
        {
            throw new NotImplementedException();
        }

        public Task<Application?> GetPersonApplications(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Application> GetPersonLocalApplicationsOfLicenseClass(int personId, int licenseClassId)
        {
            //    var personApplicationsOfLicenseClass = await _dbSet
            //                                               .Include(a => a.LocalDrivingLicenseApplication)
            //                                               .FirstOrDefaultAsync
            //                                               (
            //                                                   a => a.PersonId == personId                                                     
            //                                                   //a.LocalDrivingLicenseApplication.LicenseClassId == licenseClassId 
            //                                                   && a.Status == EnStatus.New || a.Status == EnStatus.Completed
            //                                               );

            var personApplicationsOfLicenseClass = await _DvldContext.LocalDrivingLicenseApplications
                                                        .Include(a => a.Application)
                                                        .FirstOrDefaultAsync
                                                         (
                                                           a => a.Application.PersonId == personId &&
                                                           a.Application.Status == EnStatus.New || a.Application.Status == EnStatus.Completed &&
                                                           a.LicenseClassId == licenseClassId 
                                                        );
            return personApplicationsOfLicenseClass?.Application ?? null;
         }


        public async Task<bool>  UpdateStatus(int applicationId, EnStatus newStatus)
        {
            var application = await _dbSet
                           .FirstOrDefaultAsync(a => a.Id == applicationId);

            if (application is null)
                return false;


            application.Status = newStatus;
            application.LastStatusDate = DateTime.Now;
            return true;


        }

        public async Task<bool> MarkDeleted(int localDrivvingLicensesApplicationId)
        {
            await _dbSet.Where(l => l.LocalDrivingLicenseApplication.Id == localDrivvingLicensesApplicationId)
                        .ExecuteUpdateAsync(s => s.SetProperty(a => a.Status, EnStatus.Canceled));
            return true;
        }

        public Task<bool> ApplicationHaveIssuedLicense(int applicationId)
        {
            throw new NotImplementedException();
        }
    }   
}
