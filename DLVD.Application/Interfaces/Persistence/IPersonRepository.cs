using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence;

public interface IPersonRepository
{
    public Task<IEnumerable<Person>> All();
    public Task<Person?> GetById(int id);
    public Task<IEnumerable<Person>> GetAllAsync();
    public Task<IEnumerable<Person>> GetPaginatedAsync(
        int Page, string searchTerm,
        Expression<Func<Person, object>> sortCoulmnExpression,
        string? sortOrder);
    public Task<bool> Add(Person entity);
    public Task<bool> Update(Person entity);
    public Task<bool> Delete(Person entity);
    public Task<bool> Delete(int id);
    public Task<User> GetAssosiatedUser();
    public Task<Application> GetAllApplication(int Id);
}
