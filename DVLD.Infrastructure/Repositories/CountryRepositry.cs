﻿using DVLD.Domain.Entities;
using DVLD.App.Interfaces.Persistence;
using Microsoft.Extensions.Logging;


namespace DVLD.Data.Repositories
{
    public class CountryRepositry : ICountryRepository
    {
        protected readonly ILogger _logger;

        private DvldContext _DvldContext;
        public CountryRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
        }
        public Task<IEnumerable<Country>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
