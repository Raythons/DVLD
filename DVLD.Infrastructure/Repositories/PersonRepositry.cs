using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using DLVD.App.extensions;
using System.Reflection.Metadata.Ecma335;

namespace DVLD.Data.Repositories
{
    public class PersonRepositry : IPersonRepository
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<Person> _dbSet;

        public PersonRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.Persons;
        }
        
       
      
        public async Task<Person?> GetById(int id)
        {
            return await _dbSet.Include(p => p.Country).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Person>> GetPaginatedAsync(
         int Page, string searchTerm,
         Expression<Func<Person, object>> sortCoulmnExpression,
        string sortOrder = "asec"
        )
        {
            IQueryable<Person> PaginatedPersons = _dbSet;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                PaginatedPersons = PaginatedPersons
                                         .Where(u =>
                                         u.FirstName.Contains(searchTerm) ||
                                         u.SecondName.Contains(searchTerm) ||
                                         u.ThirdName.Contains(searchTerm) ||
                                         u.LastName.Contains(searchTerm));
            }


            PaginatedPersons = PaginatedPersons.ApplySorting(
                sortOrder,
                sortCoulmnExpression).Skip((Page - 1) * 20)
                                      .Take(20);

            return await PaginatedPersons.ToListAsync();
        }

        public async Task<bool> Add(Person person)
        {
            try
            {
                await _dbSet.AddAsync(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return true;
        }

        public async Task<bool> Update(Person person)
        {
            try
            {
                var FoundPerson = await _dbSet.FirstOrDefaultAsync(p => p.Id == person.Id);
                if (FoundPerson is  null)
                        return false; 

                FoundPerson.FirstName = person.FirstName;
                FoundPerson.SecondName = person.SecondName;
                FoundPerson.ThirdName = person.ThirdName;
                FoundPerson.LastName = person.LastName;
                FoundPerson.BirthDate = person.BirthDate;
                FoundPerson.Email = person.Email;
                FoundPerson.Phone = person.Phone;
                FoundPerson.NationalityCountryId = person.NationalityCountryId;
                FoundPerson.Address = person.Address;

                if (person.Image !=  null)      
                    FoundPerson.Image = person.Image;
                

                return true;
            }
            catch (Exception e)
            {

                _logger.LogError(e, "{Repo} All Function Error", typeof(PersonRepositry));
                throw;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await _dbSet.Where(p => p.Id == id).ExecuteDeleteAsync();
                if (result == 0)
                    return false;
                return true;

            }
            catch (DbUpdateException e)
            {
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data.Keys);
                    Console.WriteLine(e.Data.Values);
                    throw;
                }


                // TO Do
            }
        }


        public Task<IEnumerable<Person>> All()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Person entity)
        {
            throw new NotImplementedException();
        }

     

        public Task<Application> GetAllApplication(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAssosiatedUser()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> isConnectedEntity(int personId)
        {
            var person = await _dbSet.Where(p => p.Id == personId &&
                                                  p.User != null ||
                                                  p.Applications != null ||
                                                  p.Driver != null
                                            ).FirstOrDefaultAsync();
                                                   

            return person != null;
        }
    }
}
