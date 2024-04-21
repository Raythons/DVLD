using DLVD.App.Interfaces.Persistence;
using DVLD.Data;
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Infrastructure.Repositories
{
    public class RefreshTokenRepositry : IRefreshTokenRepositry
    {
        protected readonly ILogger _logger;
        private DvldContext _DvldContext;
        private DbSet<RefreshToken> _dbSet;
        public RefreshTokenRepositry(ILogger logger, DvldContext context)
        {
            _logger = logger;
            _DvldContext = context;
            _dbSet = _DvldContext.RefreshTokens;

        }
        public async Task<bool> AddAsync(RefreshToken entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public async  Task<RefreshToken?> GetById(string tokenId)
        {
            var refreshToken = await _dbSet.FirstOrDefaultAsync(r => r.Token == tokenId);

            if (refreshToken == null)
                return null;

            return refreshToken;
        }

        public Task<bool> Revoke(RefreshToken entity)
        {
            throw new NotImplementedException();
        }
   
    }
}
