using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Data.Repositories;

public class UserRepository : IUserRepository
{

    protected readonly ILogger _logger;
    private DvldContext _DvldContext;
    private DbSet<User> _dbSet;
    public UserRepository(ILogger logger, DvldContext context)
    {
        _logger = logger;
        _DvldContext = context;
        _dbSet = _DvldContext.Users;

    }
    public IQueryable<User> GetPaginatedUsers()
    {
        return  _dbSet;
    } 
    public  async Task<User?> GetById(int userId)
    {
        try
        {
            return await _DvldContext.Users
                            .Include(u => u.Person)
                            .FirstOrDefaultAsync(u => u.Id == userId);

        }
        catch (Exception e )
        {
            _logger.LogError(e, "{Repo} GetById Function Error", typeof(UserRepository));
            throw;
        }
    }

    public async Task<bool> AddAsync(User entity)
    {

        try
        {
            await _DvldContext.Users.AddAsync(entity);
            return true;
        }

        catch (Exception e)
        {
            _logger.LogError(e, "{Repo} Add Function Error", typeof(UserRepository));
            throw;
        }
    }

    public async Task<bool> Update(User user)
    {
        try
        {
            
            var FoundUser = await _dbSet.FirstOrDefaultAsync(u => u.Id == user.Id);
            if (FoundUser is null)
                return false;

            FoundUser.UserName = user.UserName;
            FoundUser.Password = user.Password;
           //FoundUser.Person.FirstName = user.Person.FirstName;
           //FoundUser.Person.SecondName = user.Person.SecondName;
           //FoundUser.Person.ThirdName = user.Person.ThirdName;
           //FoundUser.Person.LastName = user.Person.LastName;
           //FoundUser.Person.BirthDate = user.Person.BirthDate;
           //FoundUser.Person.Email = user.Person.Email;
           //FoundUser.Person.Phone = user.Person.Phone;
           //FoundUser.Person.NationalityCountryId = user.Person.NationalityCountryId;
           //FoundUser.Person.Address = user.Person.Address;

            return true;
        }
        catch (Exception e)
        {

            _logger.LogError(e, "{Repo} All Function Error", typeof(PersonRepositry));
            throw;
        }
    }

    public Task<bool> DeActivate(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Login(User entity)
    {
        throw new NotImplementedException();
    }


    public async Task<bool> UpdatePassword(User entity)
    {
        try
        {
            var toUpdate =  await _DvldContext.Users.FirstOrDefaultAsync(e => e.Id == entity.Id);
            if (toUpdate == null)
                return false;
            toUpdate.Password = entity.Password;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error in method {nameof(UpdatePassword)} in {nameof(UserRepository)}");
            throw;
        }
        return true;
    }

    public Task<bool> UpdateUserName(int id, string newUserName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Application>> UserCreatedApplications(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DetainedLicense>> UserCreatedDetainedLicenses(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Driver>> UserCreatedDrivers(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<InternationalDrivingLicense>> UserCreatedInternationalDrivingLicenses(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<License>> UserCreatedLicenses(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Test>> UserCreatedTests(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DetainedLicense>> UserDetainedLicensesReleased(int userId)
    {
        throw new NotImplementedException();
    }
}
