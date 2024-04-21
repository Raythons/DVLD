using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence;

public interface ICountryRepository
{
    Task<IEnumerable<Country>> GetAll();
}
