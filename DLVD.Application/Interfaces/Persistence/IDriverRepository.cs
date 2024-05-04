using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using DVLD.Domain.Entities.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence;

public interface IDriverRepository
{
    public Task<IEnumerable<Driver>> All();
    public Task<PagedList<DriversBreifInfoView>> GetAllPaginatedAsync(
      Expression<Func<DriversBreifInfoView, bool>> filter = null,
      Expression<Func<DriversBreifInfoView, object>> orderBy = null,
      bool descending = true,
      int page = 1,
      int pageSize = 20);
    public Task<Driver?> GetById(int id);
    public Task<bool> Add(Driver entity);
    public Task<bool> Update(Driver entity);
    public Task<bool> Update(int driverId);
    public Task<bool> Delete(Driver entity);
    public Task<bool> DeleteById(int id);
    public Task<InternationalDrivingLicense> GetInternationalDrivingLicense();
    public Task<User> GetCreatedByUser(int driverId);
    public Task<Person> GetAssosiatedPerson(int Id);

}
