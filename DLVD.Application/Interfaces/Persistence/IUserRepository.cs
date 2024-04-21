using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence;

public interface IUserRepository
{
    public Task<bool> AddAsync(User entity);
    public IQueryable<User> GetPaginatedUsers();
    public Task<User?> GetById(int userId);
    public Task<bool> Update(User entity);
    public Task<bool> Delete(User entity);
    public Task<bool> UpdateUserName(int id, string newUserName);
    public Task<bool> Login(User entity);
    public Task<bool> UpdatePassword(User entity);
    public Task<bool> DeActivate(int id);
    public Task<IEnumerable<Driver>>UserCreatedDrivers(int userId);
    public Task<IEnumerable<Application>> UserCreatedApplications(int userId);
    public Task<IEnumerable<License>> UserCreatedLicenses(int userId);
    public Task<IEnumerable<DetainedLicense>> UserCreatedDetainedLicenses(int userId);
    public Task<IEnumerable<DetainedLicense>> UserDetainedLicensesReleased(int userId);
    public Task<IEnumerable<InternationalDrivingLicense>> UserCreatedInternationalDrivingLicenses(int userId);
    public Task<IEnumerable<Test>> UserCreatedTests(int userId);

}
