using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Interfaces.Persistence
{
    public interface IRefreshTokenRepositry
    {
        public Task<bool> AddAsync(RefreshToken entity);
        public Task<RefreshToken?> GetById(string toenId);
        public Task<bool> Revoke(RefreshToken entity);
    }
}
